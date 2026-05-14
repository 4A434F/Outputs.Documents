const state = {
    maps: [],
    viewMode: "copybook",
    selectedCopybook: "",
    selectedObject: "",
    selectedStatus: "",
    search: ""
};

const elements = {
    title: document.querySelector("#page-title"),
    lead: document.querySelector("#page-lead"),
    viewFilter: document.querySelector("#view-filter"),
    copybookFilter: document.querySelector("#copybook-filter"),
    objectFilter: document.querySelector("#object-filter"),
    statusFilter: document.querySelector("#status-filter"),
    searchFilter: document.querySelector("#search-filter"),
    mapSection: document.querySelector("#map-section"),
    summaryCopybook: document.querySelector("#summary-copybook"),
    summaryGroups: document.querySelector("#summary-groups"),
    summarySourceLines: document.querySelector("#summary-source-lines"),
    summaryRows: document.querySelector("#summary-rows"),
    summaryRaw: document.querySelector("#summary-raw")
};

init().catch(error => {
    elements.mapSection.innerHTML = `
        <article class="empty-state">
            <h2>Unable to load migration maps</h2>
            <p>${escapeHtml(error.message)}</p>
            <p>Check that migration-data.js exists beside index.html, or run this report through a local static server so the browser can fetch JSON files.</p>
        </article>`;
});

async function init() {
    state.maps = await loadMigrationMaps();
    state.selectedCopybook = state.maps[0]?.copybook ?? "";
    bindFilters();
    render();
}

async function loadMigrationMaps() {
    if (Array.isArray(window.MIGRATION_MAPS) && window.MIGRATION_MAPS.length > 0) {
        return window.MIGRATION_MAPS;
    }

    const indexResponse = await fetch("../migration-maps/index.json");
    if (!indexResponse.ok) {
        throw new Error(`Could not load migration map index (${indexResponse.status}).`);
    }

    const index = await indexResponse.json();
    return Promise.all(index.maps.map(async entry => {
        const response = await fetch(`../migration-maps/${entry.file}`);
        if (!response.ok) {
            throw new Error(`Could not load ${entry.file} (${response.status}).`);
        }

        return response.json();
    }));
}

function bindFilters() {
    updateCopybookOptions();
    updateObjectOptions();

    elements.viewFilter.addEventListener("change", event => {
        state.viewMode = event.target.value;
        state.selectedCopybook = state.viewMode === "domain" ? "" : state.maps[0]?.copybook ?? "";
        state.selectedObject = "";
        updateCopybookOptions();
        updateObjectOptions();
        render();
    });

    elements.copybookFilter.addEventListener("change", event => {
        state.selectedCopybook = event.target.value;
        updateObjectOptions();
        render();
    });

    elements.objectFilter.addEventListener("change", event => {
        state.selectedObject = event.target.value;
        render();
    });

    elements.statusFilter.addEventListener("change", event => {
        state.selectedStatus = event.target.value;
        render();
    });

    elements.searchFilter.addEventListener("input", event => {
        state.search = event.target.value.trim().toLowerCase();
        render();
    });
}

function render() {
    if (state.viewMode === "domain") {
        renderDomainView();
        return;
    }

    renderCopybookView();
}

function renderCopybookView() {
    elements.objectFilter.disabled = true;
    const map = state.maps.find(item => item.copybook === state.selectedCopybook) ?? state.maps[0];
    if (!map) {
        elements.mapSection.innerHTML = `<article class="empty-state"><h2>No migration maps found</h2></article>`;
        return;
    }

    elements.title.textContent = `${map.copybook} to typed document domain`;
    elements.lead.textContent = map.description;
    elements.summaryCopybook.textContent = map.copybook;

    const renderedGroups = map.mappings
        .map(group => ({ group, rows: filterRows(group.rows) }))
        .filter(item => item.rows.length > 0 || groupMatchesSearch(item.group));

    const visibleRows = renderedGroups.reduce((sum, item) => sum + item.rows.length, 0);
    const sourceLines = renderedGroups.reduce((sum, item) => sum + countSourceLines(item.rows), 0);
    const rawRows = renderedGroups.reduce(
        (sum, item) => sum + item.rows.filter(row => row.status === "raw" || row.status === "candidate").length,
        0);

    elements.summaryGroups.textContent = renderedGroups.length.toString();
    elements.summarySourceLines.textContent = sourceLines.toString();
    elements.summaryRows.textContent = visibleRows.toString();
    elements.summaryRaw.textContent = rawRows.toString();

    elements.mapSection.innerHTML = renderedGroups.length === 0
        ? `<article class="empty-state"><h2>No mappings match the filters</h2></article>`
        : renderedGroups.map(item => renderGroup(item.group, item.rows)).join("");
}

function renderDomainView() {
    elements.objectFilter.disabled = false;
    updateObjectOptions();

    const maps = selectedMaps();
    const objectGroup = buildObjectGroup(state.selectedObject, maps);
    const visibleRows = filterDomainRows(objectGroup.rows);

    const mapNames = maps.map(map => map.copybook).join(", ");
    const sourceLines = countSourceLines(visibleRows);
    const rawRows = visibleRows.filter(row => row.status === "raw" || row.status === "candidate").length;

    elements.title.textContent = `${state.selectedObject || ".NET object"} to copybook fields`;
    elements.lead.textContent = `This view starts from the selected .NET object. The left side lists every known property for that object; the right side shows copybook fields bound to each property. Scope: ${mapNames || "all copybooks"}.`;
    elements.summaryCopybook.textContent = state.selectedCopybook || "All";
    elements.summaryGroups.textContent = visibleRows.length > 0 ? "1" : "0";
    elements.summarySourceLines.textContent = sourceLines.toString();
    elements.summaryRows.textContent = visibleRows.length.toString();
    elements.summaryRaw.textContent = rawRows.toString();

    elements.mapSection.innerHTML = visibleRows.length === 0
        ? `<article class="empty-state"><h2>No properties match the filters</h2></article>`
        : renderDomainGroup(objectGroup, visibleRows);
}

function selectedMaps() {
    if (!state.selectedCopybook) {
        return state.maps;
    }

    return state.maps.filter(map => map.copybook === state.selectedCopybook);
}

function buildObjectCatalog(maps = state.maps) {
    const catalog = new Map();

    for (const map of maps) {
        for (const mapping of map.mappings) {
            const objectName = normalizeObjectName(mapping.targetType);
            const object = catalog.get(objectName) ?? {
                name: objectName,
                properties: new Map()
            };

            for (const row of mapping.rows) {
                if (!row.target || row.status === "container") {
                    continue;
                }

                const property = normalizeTarget(row.target, objectName);
                if (!property || property === objectName) {
                    continue;
                }

                object.properties.set(property, property);
            }

            catalog.set(objectName, object);
        }
    }

    return [...catalog.values()]
        .filter(item => isDomainObjectOption(item.name))
        .filter(item => item.properties.size > 0)
        .sort(compareDomainObjects);
}

function compareDomainObjects(left, right) {
    const preferredOrder = [
        "DocumentInformation",
        "PostalAddress",
        "Entity",
        "Policy",
        "Premium",
        "RiskUnit",
        "Coverage[]",
        "PrintPayloadRecordControl",
        "Document primitives"
    ];

    const leftIndex = preferredOrder.indexOf(left.name);
    const rightIndex = preferredOrder.indexOf(right.name);

    if (leftIndex >= 0 || rightIndex >= 0) {
        return (leftIndex < 0 ? Number.MAX_SAFE_INTEGER : leftIndex)
            - (rightIndex < 0 ? Number.MAX_SAFE_INTEGER : rightIndex);
    }

    return left.name.localeCompare(right.name);
}

function buildObjectGroup(objectName, maps) {
    const catalogObject = buildObjectCatalog(state.maps).find(item => item.name === objectName);
    if (!catalogObject) {
        return {
            title: objectName,
            sourceGroup: objectName,
            targetType: objectName,
            targetPath: objectName,
            targetLabel: ".NET object",
            decision: "mapped",
            description: `No known properties for ${objectName}.`,
            rows: []
        };
    }

    const bindingLookup = new Map();

    for (const map of maps) {
        for (const mapping of map.mappings.filter(item => normalizeObjectName(item.targetType) === objectName)) {
            for (const row of mapping.rows) {
                if (!row.target || row.status === "container" || row.status === "target-only") {
                    continue;
                }

                const property = normalizeTarget(row.target, objectName);
                const bindings = bindingLookup.get(property) ?? [];
                bindings.push({
                    copybook: map.copybook,
                    source: row.source ?? row.sourceField ?? "No source field",
                    sourceField: row.sourceField,
                    status: row.status,
                    reason: row.reason
                });
                bindingLookup.set(property, bindings);
            }
        }
    }

    return {
        title: objectName,
        sourceGroup: objectName,
        targetType: objectName,
        targetPath: objectName,
        targetLabel: ".NET object",
        decision: "mapped",
        description: `Every known ${objectName} property is listed on the left. The right side shows all selected copybook fields that bind into each property; unbound rows highlight properties with no current binding in the selected scope.`,
        rows: [...catalogObject.properties.values()]
            .sort((left, right) => left.localeCompare(right))
            .map(property => createObjectPropertyRow(property, bindingLookup.get(property) ?? []))
    };
}

function createObjectPropertyRow(property, bindings) {
    if (bindings.length === 0) {
        return {
            source: property,
            target: "No copybook binding in selected scope",
            sourceField: property,
            status: "unbound",
            statusClass: "unbound",
            copybookLineCount: 0
        };
    }

    const statuses = new Set(bindings.map(binding => binding.status));
    const status = statuses.has("raw")
        ? "raw"
        : statuses.has("candidate")
            ? "candidate"
            : "mapped";

    return {
        source: property,
        target: bindings
            .map(binding => `${binding.copybook}: ${binding.source}`)
            .join("\n"),
        sourceField: property,
        status,
        reason: bindings.map(binding => binding.reason).filter(Boolean).join(" "),
        copybookLineCount: bindings.filter(binding => binding.source && !binding.source.startsWith("No source field")).length
    };
}

function normalizeObjectName(objectName) {
    return String(objectName).replace(/\?$/, "");
}

function isDomainObjectOption(objectName) {
    return !objectName.endsWith("Contract")
        && !objectName.startsWith("Raw contract");
}

function normalizeTarget(target, objectName = "") {
    const value = String(target)
        .replace(" raw contract field", "")
        .trim();

    if (objectName === "PostalAddress") {
        return value
            .replace(/^MailingAddress\./, "")
            .replace(/^Client\.Address\./, "")
            .replace(/^Agent\.Address\./, "");
    }

    if (objectName === "Entity" || objectName === "Entity?") {
        return value
            .replace(/^Client\./, "")
            .replace(/^Agent\./, "");
    }

    if (objectName === "Policy") {
        return value.replace(/^Policy\./, "");
    }

    if (objectName === "Coverage[]") {
        return value
            .replace(/^Coverage\./, "")
            .replace(/^Coverage\.Deductible\./, "Deductible.");
    }

    return value;
}

function filterRows(rows) {
    return rows.filter(row => {
        const statusMatches = !state.selectedStatus || row.status === state.selectedStatus;
        const searchMatches = !state.search || matchesSearch([
            row.source,
            row.sourceField,
            row.target,
            row.status,
            row.reason
        ].join(" "));

        return statusMatches && searchMatches;
    });
}

function filterDomainRows(rows) {
    return rows.filter(row => {
        const statusMatches = !state.selectedStatus || row.status === state.selectedStatus;
        const searchMatches = !state.search || matchesSearch([
            row.source,
            row.sourceField,
            row.target,
            row.status,
            row.reason
        ].join(" "));

        return statusMatches && searchMatches;
    });
}

function renderGroup(group, rows) {
    const candidateClass = group.decision === "candidate" ? " candidate" : "";

    return `
        <article class="mapping-card${candidateClass}">
            <div class="card-heading source-heading">
                <p class="label">Copybook source</p>
                <h3>${escapeHtml(group.title)}</h3>
            </div>
            <div class="card-heading target-heading">
                <p class="label">${escapeHtml(group.targetLabel ?? ".NET object")}</p>
                <h3>${escapeHtml(group.targetType)}</h3>
            </div>
            <p class="mapping-explanation">${escapeHtml(group.description)}</p>
            <div class="aligned-map">
                ${rows.map(renderRow).join("")}
            </div>
        </article>`;
}

function renderDomainGroup(group, rows) {
    const candidateClass = group.decision === "candidate" ? " candidate" : "";

    return `
        <article class="mapping-card domain-card${candidateClass}">
            <div class="card-heading source-heading">
                <p class="label">.NET object properties</p>
                <h3>${escapeHtml(group.targetType)}</h3>
            </div>
            <div class="card-heading target-heading">
                <p class="label">Matching copybook fields</p>
                <h3>${escapeHtml(rows.length)} propert${rows.length === 1 ? "y" : "ies"}</h3>
            </div>
            <p class="mapping-explanation">${escapeHtml(group.description)}</p>
            <div class="aligned-map">
                ${rows.map(renderRow).join("")}
            </div>
        </article>`;
}

function renderRow(row) {
    const sourceClass = ["source-line", row.statusClass ?? row.status].filter(Boolean).join(" ");
    const targetClass = ["target-line", row.statusClass ?? row.status].filter(Boolean).join(" ");
    const source = row.source ?? "No source field in this copybook";
    const target = row.target ?? "No target";

    return `
        <div class="${sourceClass}" title="${escapeHtml(row.reason ?? "")}">${escapeHtml(source)}</div>
        <div class="${targetClass}" title="${escapeHtml(row.reason ?? "")}">${escapeHtml(target)}</div>`;
}

function updateCopybookOptions() {
    const allOption = state.viewMode === "domain"
        ? `<option value="">All copybooks</option>`
        : "";

    elements.copybookFilter.innerHTML = allOption + state.maps
        .map(map => `<option value="${escapeHtml(map.copybook)}">${escapeHtml(map.copybook)} - ${escapeHtml(map.title)}</option>`)
        .join("");

    elements.copybookFilter.value = state.selectedCopybook;
}

function updateObjectOptions() {
    const objects = buildObjectCatalog(state.maps);
    const currentExists = objects.some(item => item.name === state.selectedObject);

    if (!currentExists) {
        state.selectedObject = objects[0]?.name ?? "";
    }

    elements.objectFilter.innerHTML = objects
        .map(item => `<option value="${escapeHtml(item.name)}">${escapeHtml(item.name)}</option>`)
        .join("");

    elements.objectFilter.value = state.selectedObject;
    elements.objectFilter.disabled = state.viewMode !== "domain";
}

function countSourceLines(rows) {
    return rows.reduce((sum, row) => {
        if (typeof row.copybookLineCount === "number") {
            return sum + row.copybookLineCount;
        }

        return sum + (row.source && !row.source.startsWith("No source field") ? 1 : 0);
    }, 0);
}

function matchesSearch(value) {
    return Boolean(state.search) && value.toLowerCase().includes(state.search);
}

function groupMatchesSearch(group) {
    if (!state.search || state.selectedStatus) {
        return false;
    }

    return matchesSearch([
        group.title,
        group.sourceGroup,
        group.targetType,
        group.targetPath,
        group.description
    ].join(" "));
}

function escapeHtml(value) {
    return String(value ?? "")
        .replaceAll("&", "&amp;")
        .replaceAll("<", "&lt;")
        .replaceAll(">", "&gt;")
        .replaceAll('"', "&quot;")
        .replaceAll("'", "&#039;");
}
