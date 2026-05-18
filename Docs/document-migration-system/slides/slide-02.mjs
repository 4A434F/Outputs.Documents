import { C, bg, title, footer, node, arrow, miniPage, bandLabel } from "./theme.mjs";

function fileStack(slide, ctx, x, y, label, color) {
  for (let i = 0; i < 3; i += 1) {
    ctx.addShape(slide, { left: x + i * 12, top: y + i * 10, width: 130, height: 72, fill: C.white, line: ctx.line(C.line, 1) });
  }
  ctx.addShape(slide, { left: x + 24, top: y + 20, width: 130, height: 18, fill: color, line: ctx.line() });
  ctx.addText(slide, {
    text: label,
    left: x + 24,
    top: y + 50,
    width: 130,
    height: 28,
    fontSize: 13,
    bold: true,
    color: C.ink,
    align: "center",
    insets: { left: 4, right: 4, top: 0, bottom: 0 }
  });
}

export async function slide02(presentation, ctx) {
  const slide = presentation.slides.add();
  bg(slide, ctx);
  title(slide, ctx, "migration task", "Convert each legacy document ID into a report", {
    note: "The first output is not code. It is a development-ready map for one document."
  });

  fileStack(slide, ctx, 82, 212, "copybooks", C.amber);
  fileStack(slide, ctx, 82, 338, "programs", C.blue);
  fileStack(slide, ctx, 82, 464, "overlays", C.teal);

  ctx.addShape(slide, { left: 320, top: 238, width: 160, height: 250, fill: C.dark2, line: ctx.line() });
  ctx.addShape(slide, { left: 344, top: 268, width: 112, height: 190, fill: C.bg, line: ctx.line() });
  ctx.addText(slide, {
    text: "analyze\nnormalize\nstructure",
    left: 336,
    top: 326,
    width: 128,
    height: 72,
    fontSize: 16,
    bold: true,
    color: C.white,
    align: "center",
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });

  arrow(slide, ctx, { x1: 250, y1: 360, x2: 316, y2: 360, color: C.muted });
  arrow(slide, ctx, { x1: 486, y1: 360, x2: 570, y2: 360, color: C.muted });

  miniPage(slide, ctx, {
    x: 590,
    y: 178,
    w: 250,
    h: 360,
    titleText: "Document ID Report",
    bands: [
      { color: C.redSoft, pct: 0.82 },
      { color: C.blueSoft, pct: 0.68 },
      { color: C.tealSoft, pct: 0.76 },
      { color: C.greenSoft, pct: 0.58 },
      { color: C.amberSoft, pct: 0.70 },
      { color: C.violetSoft, pct: 0.62 }
    ]
  });

  const x = 920;
  bandLabel(slide, ctx, { x, y: 208, w: 210, text: "legacy mapping", color: C.amber });
  bandLabel(slide, ctx, { x, y: 266, w: 210, text: "new contract shape", color: C.blue });
  bandLabel(slide, ctx, { x, y: 324, w: 210, text: "sample data", color: C.teal });
  bandLabel(slide, ctx, { x, y: 382, w: 210, text: "template sections", color: C.green });
  bandLabel(slide, ctx, { x, y: 440, w: 210, text: "reuse candidates", color: C.violet });
  arrow(slide, ctx, { x1: 846, y1: 360, x2: 914, y2: 360, color: C.muted });

  footer(slide, ctx, 2);
  return slide;
}
