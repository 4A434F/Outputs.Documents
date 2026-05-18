import { C, bg, title, footer, node, arrow, chip } from "./theme.mjs";

export async function slide07(presentation, ctx) {
  const slide = presentation.slides.add();
  bg(slide, ctx);
  title(slide, ctx, "execution user flow", "Apps and APIs build the model, then ask the renderer for output");

  const entryY = 190;
  node(slide, ctx, { x: 86, y: entryY, w: 190, h: 76, label: "endpoint", sub: "API request", fill: C.white, accent: C.blue });
  node(slide, ctx, { x: 86, y: entryY + 116, w: 190, h: 76, label: "button", sub: "dashboard action", fill: C.white, accent: C.teal });
  node(slide, ctx, { x: 86, y: entryY + 232, w: 190, h: 76, label: "batch job", sub: "scheduled run", fill: C.white, accent: C.amber });

  ctx.addShape(slide, { left: 352, top: 240, width: 220, height: 178, fill: C.blueSoft, line: ctx.line(C.blue, 1) });
  ctx.addText(slide, { text: "model builder", left: 378, top: 270, width: 168, height: 26, fontSize: 20, bold: true, color: C.ink, align: "center", insets: { left: 0, right: 0, top: 0, bottom: 0 } });
  chip(slide, ctx, { x: 384, y: 320, w: 156, text: "required format", fill: C.white, color: C.blue, stroke: C.blue });
  chip(slide, ctx, { x: 384, y: 362, w: 156, text: "IDocumentModel", fill: C.white, color: C.blue, stroke: C.blue });

  node(slide, ctx, { x: 664, y: 242, w: 230, h: 174, label: "DocumentRenderer", sub: "selects template\nrenders HTML\ncalls PDF provider", fill: C.dark2, stroke: C.dark2, color: C.white, accent: C.red });
  node(slide, ctx, { x: 986, y: 242, w: 190, h: 174, label: "PDF bytes", sub: "return\ndownload\narchive", fill: C.greenSoft, stroke: C.green, accent: C.green });

  ctx.addShape(slide, { left: 300, top: 228, width: 2, height: 232, fill: C.muted, line: ctx.line() });
  ctx.addShape(slide, { left: 282, top: 227, width: 18, height: 2, fill: C.muted, line: ctx.line() });
  ctx.addShape(slide, { left: 282, top: 343, width: 18, height: 2, fill: C.muted, line: ctx.line() });
  ctx.addShape(slide, { left: 282, top: 459, width: 18, height: 2, fill: C.muted, line: ctx.line() });
  arrow(slide, ctx, { x1: 302, y1: 329, x2: 346, y2: 329, color: C.muted });
  arrow(slide, ctx, { x1: 578, y1: 329, x2: 658, y2: 329, color: C.muted });
  arrow(slide, ctx, { x1: 900, y1: 329, x2: 980, y2: 329, color: C.muted });

  footer(slide, ctx, 7);
  return slide;
}
