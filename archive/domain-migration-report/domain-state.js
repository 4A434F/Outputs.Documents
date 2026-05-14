const domainState = Array.isArray(window.DOMAIN_STATE) ? window.DOMAIN_STATE : [];

const elements = {
    domainCards: document.querySelector("#domain-cards"),
    domainFilter: document.querySelector("#domain-filter"),
    objectFilter: document.querySelector("#domain-object-filter"),
    searchFilter: document.querySelector("#domain-search-filter"),
    detail: document.querySelector("#domain-detail"),
    summaryDomains: document.querySelector("#domain-summary-domains"),
    summaryObjects: document.querySelector("#domain-summary-objects"),
    summaryProperties: document.querySelector("#domain-summary-properties"),
    summaryVisible: document.querySelector("#domain-summary-visible"),
    summarySelected: document.querySelector("#domain-summary-selected"),
};

const state = {
    domain: "",
    object: "",
    search: "",
};

const collator = new Intl.Collator(undefined, { sensitivity: "base" });

function escapeHtml(value) {
    return String(value ?? "")
        .replaceAll("&", "&amp;")
        .replaceAll("<", "&lt;")
        .replaceAll(">", "&gt;")
        .replaceAll("\"", "&quot;")
        .replaceAll("'", "&#039;");
}

function normalize(value) {
    return String(value ?? "").toLowerCase();
}

function unique(values) {
    return [...new Set(values.filter(Boolean))].sort(collator.compare);
}

function domains() {
    return unique(domainState.map(item => item.domain));
}

function objectsForDomain(domain) {
    return domainState
        .filter(item => !domain || item.domain === domain)
        .sort((a, b) => collator.compare(a.name, b.name));
}

function objectMatchesSearch(item, query) {
    if (!query) {
        return true;
    }

    const haystack = [
        item.domain,
        item.name,
        item.displayName,
        item.description,
        item.namespace,
        item.file,
        ...(item.aliases ?? []),
        ...(item.tags ?? []),
        ...(item.properties ?? []).flatMap(property => [
            property.name,
            property.displayName,
            property.type,
            property.description,
            ...(property.aliases ?? []),
            ...(property.tags ?? []),
        ]),
    ].map(normalize).join(" ");

    return haystack.includes(normalize(query));
}

function filteredObjects() {
    return objectsForDomain(state.domain)
        .filter(item => !state.object || item.name === state.object)
        .filter(item => objectMatchesSearch(item, state.search));
}

function renderOptions(select, options, selected, allLabel) {
    select.innerHTML = [
        `<option value="">${escapeHtml(allLabel)}</option>`,
        ...options.map(option => {
            const isSelected = option === selected ? " selected" : "";
            return `<option value="${escapeHtml(option)}"${isSelected}>${escapeHtml(option)}</option>`;
        }),
    ].join("");
}

function renderFilters() {
    renderOptions(elements.domainFilter, domains(), state.domain, "All domains");

    const objectOptions = objectsForDomain(state.domain).map(item => item.name);
    if (state.object && !objectOptions.includes(state.object)) {
        state.object = "";
    }

    renderOptions(elements.objectFilter, objectOptions, state.object, "All objects");
    elements.searchFilter.value = state.search;
}

function renderDomainCards() {
    const grouped = domains().map(domain => ({
        domain,
        objects: objectsForDomain(domain),
    }));

    elements.domainCards.innerHTML = grouped.map(group => `
        <article class="domain-state-card">
            <div>
                <p class="eyebrow">${escapeHtml(group.objects.length)} objects</p>
                <h3>${escapeHtml(group.domain)}</h3>
            </div>
            <div class="domain-object-list">
                ${group.objects.map(item => `
                    <button
                        class="object-chip${state.object === item.name ? " active" : ""}"
                        type="button"
                        data-domain="${escapeHtml(group.domain)}"
                        data-object="${escapeHtml(item.name)}">
                        <span>${escapeHtml(item.name)}</span>
                        <small>${escapeHtml(item.displayName)}</small>
                    </button>
                `).join("")}
            </div>
        </article>
    `).join("");

    elements.domainCards.querySelectorAll("[data-object]").forEach(button => {
        button.addEventListener("click", () => {
            state.domain = button.dataset.domain ?? "";
            state.object = button.dataset.object ?? "";
            render();
            document.querySelector("#domain-detail")?.scrollIntoView({ behavior: "smooth", block: "start" });
        });
    });
}

function renderPills(values, label) {
    if (!values?.length) {
        return "";
    }

    return `
        <div class="meta-pills" aria-label="${escapeHtml(label)}">
            ${values.map(value => `<span class="pill">${escapeHtml(value)}</span>`).join("")}
        </div>
    `;
}

function renderProperty(property) {
    return `
        <article class="property-card">
            <div class="property-heading">
                <strong>${escapeHtml(property.name)}</strong>
                <code>${escapeHtml(property.type)}</code>
            </div>
            <p>${escapeHtml(property.displayName)}</p>
            <p class="muted-text">${escapeHtml(property.description)}</p>
            ${renderPills(property.aliases, "Property aliases")}
            ${renderPills(property.tags, "Property tags")}
        </article>
    `;
}

function renderObjectCard(item) {
    const propertyCount = item.properties?.length ?? 0;
    return `
        <article class="domain-detail-card">
            <header>
                <div>
                    <p class="eyebrow">${escapeHtml(item.domain)}</p>
                    <h3>${escapeHtml(item.name)}</h3>
                </div>
                <span class="count-badge">${propertyCount} props</span>
            </header>
            <p class="display-name">${escapeHtml(item.displayName)}</p>
            <p>${escapeHtml(item.description)}</p>
            <dl class="object-meta">
                <div>
                    <dt>Namespace</dt>
                    <dd>${escapeHtml(item.namespace)}</dd>
                </div>
                <div>
                    <dt>File</dt>
                    <dd>${escapeHtml(item.file)}</dd>
                </div>
            </dl>
            ${renderPills(item.aliases, "Object aliases")}
            ${renderPills(item.tags, "Object tags")}
            <div class="property-grid">
                ${propertyCount
                    ? item.properties.map(renderProperty).join("")
                    : `<p class="empty-state">No annotated properties on this object yet.</p>`}
            </div>
        </article>
    `;
}

function renderDetails() {
    const objects = filteredObjects();

    if (!domainState.length) {
        elements.detail.innerHTML = `
            <article class="empty-state-card">
                <h2>No domain objects found</h2>
                <p>Check that <code>domain-state-data.js</code> was generated from the domain project.</p>
            </article>
        `;
        return;
    }

    if (!objects.length) {
        elements.detail.innerHTML = `
            <article class="empty-state-card">
                <h2>No objects match the current filters</h2>
                <p>Try a different domain, object, or search term.</p>
            </article>
        `;
        return;
    }

    elements.detail.innerHTML = objects.map(renderObjectCard).join("");
}

function renderSummary() {
    const visible = filteredObjects();
    const allProperties = domainState.reduce((sum, item) => sum + (item.properties?.length ?? 0), 0);

    elements.summaryDomains.textContent = domains().length;
    elements.summaryObjects.textContent = domainState.length;
    elements.summaryProperties.textContent = allProperties;
    elements.summaryVisible.textContent = visible.length;
    elements.summarySelected.textContent = state.domain || "All";
}

function render() {
    renderFilters();
    renderDomainCards();
    renderSummary();
    renderDetails();
}

elements.domainFilter.addEventListener("change", event => {
    state.domain = event.target.value;
    state.object = "";
    render();
});

elements.objectFilter.addEventListener("change", event => {
    state.object = event.target.value;
    render();
});

elements.searchFilter.addEventListener("input", event => {
    state.search = event.target.value;
    renderSummary();
    renderDetails();
});

render();
