import { C, bg, title, footer, arrow, bandLabel } from "./theme.mjs";

function step(slide, ctx, x, y, w, h, n, label, output, color) {
  ctx.addShape(slide, { left: x, top: y, width: w, height: h, fill: C.white, line: ctx.line(C.line, 1) });
  ctx.addShape(slide, { left: x, top: y, width: 42, height: h, fill: color, line: ctx.line() });
  ctx.addText(slide, { text: n, left: x, top: y + 24, width: 42, height: 28, fontSize: 22, bold: true, color: C.white, align: "center", insets: { left: 0, right: 0, top: 0, bottom: 0 } });
  ctx.addText(slide, { text: label, left: x + 58, top: y + 16, width: w - 76, height: 24, fontSize: 15, bold: true, color: C.ink, insets: { left: 0, right: 0, top: 0, bottom: 0 } });
  ctx.addText(slide, { text: output, left: x + 58, top: y + 43, width: w - 76, height: 24, fontSize: 10, color: C.muted, insets: { left: 0, right: 0, top: 0, bottom: 0 } });
}

export async function slide04(presentation, ctx) {
  const slide = presentation.slides.add();
  bg(slide, ctx);
  title(slide, ctx, "migration user flow", "From source assets to a development package");

  bandLabel(slide, ctx, { x: 80, y: 174, w: 180, text: "inputs", color: C.amber });
  bandLabel(slide, ctx, { x: 550, y: 174, w: 180, text: "analysis", color: C.blue });
  bandLabel(slide, ctx, { x: 1018, y: 174, w: 180, text: "handoff", color: C.green });

  const y = 276;
  const steps = [
    ["01", "collect legacy files", "copybooks, programs, overlays", C.amber],
    ["02", "map document behavior", "fields, conditions, sections", C.blue],
    ["03", "define new structure", "contract + reusable domain pieces", C.teal],
    ["04", "create samples", "renderable examples for QA", C.green]
  ];
  steps.forEach(([n, label, output, color], i) => {
    const x = 86 + i * 292;
    step(slide, ctx, x, y, 224, 86, n, label, output, color);
    if (i < steps.length - 1) arrow(slide, ctx, { x1: x + 232, y1: y + 43, x2: x + 282, y2: y + 43, color: C.muted });
  });

  ctx.addShape(slide, { left: 96, top: 444, width: 1080, height: 92, fill: C.dark2, line: ctx.line() });
  ctx.addText(slide, {
    text: "handoff package",
    left: 128,
    top: 464,
    width: 190,
    height: 24,
    fontSize: 17,
    bold: true,
    color: C.white,
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });
  ["Doc ID report", "proposed contract", "sample model", "template notes", "reuse candidates"].forEach((label, i) => {
    ctx.addShape(slide, { left: 340 + i * 154, top: 464, width: 124, height: 38, fill: "#303C48", line: ctx.line("#4A5967", 1) });
    ctx.addText(slide, { text: label, left: 344 + i * 154, top: 475, width: 116, height: 18, fontSize: 10.5, bold: true, color: C.white, align: "center", insets: { left: 0, right: 0, top: 0, bottom: 0 } });
  });

  footer(slide, ctx, 4);
  return slide;
}
