import { C, bg, title, footer, node, arrow, chip } from "./theme.mjs";

export async function slide10(presentation, ctx) {
  const slide = presentation.slides.add();
  bg(slide, ctx);
  title(slide, ctx, "FSCD cancellation example", "BGOW0044 shows the full system in one document family");

  node(slide, ctx, { x: 80, y: 224, w: 188, h: 118, label: "BGOW0044", sub: "legacy cancellation copybook", fill: C.amberSoft, stroke: C.amber, accent: C.amber });
  node(slide, ctx, { x: 340, y: 190, w: 220, h: 88, label: "Doc ID report", sub: "1040 / 1176 mapping", fill: C.white, accent: C.blue });
  node(slide, ctx, { x: 340, y: 324, w: 220, h: 88, label: "Contract model", sub: "BGOW0044Contract\nFS000 proposal", fill: C.white, accent: C.teal });

  ctx.addShape(slide, { left: 650, top: 168, width: 266, height: 264, fill: C.dark2, line: ctx.line() });
  ctx.addText(slide, { text: "selection rule", left: 690, top: 190, width: 186, height: 24, fontSize: 20, bold: true, color: C.white, align: "center", insets: { left: 0, right: 0, top: 0, bottom: 0 } });
  chip(slide, ctx, { x: 700, y: 248, w: 166, text: "1040 -> FS1040", fill: C.blueSoft, color: C.blue, stroke: C.blue });
  chip(slide, ctx, { x: 700, y: 304, w: 166, text: "1176 -> FS1176", fill: C.tealSoft, color: C.teal, stroke: C.teal });
  chip(slide, ctx, { x: 700, y: 360, w: 166, text: "else -> default/null", fill: "#303C48", color: C.white, stroke: "#4A5967" });

  node(slide, ctx, { x: 1002, y: 170, w: 176, h: 86, label: "LetterLayout", sub: "A4 + address + subject", fill: C.white, accent: C.blue });
  node(slide, ctx, { x: 1002, y: 294, w: 176, h: 86, label: "shared parts", sub: "signature / payment / table", fill: C.white, accent: C.green });
  node(slide, ctx, { x: 1002, y: 458, w: 176, h: 86, label: "PDF", sub: "rendered cancellation letter", fill: C.redSoft, stroke: C.red, accent: C.red });

  arrow(slide, ctx, { x1: 274, y1: 283, x2: 334, y2: 234, color: C.muted });
  arrow(slide, ctx, { x1: 274, y1: 283, x2: 334, y2: 368, color: C.muted });
  arrow(slide, ctx, { x1: 566, y1: 234, x2: 644, y2: 256, color: C.muted });
  arrow(slide, ctx, { x1: 566, y1: 368, x2: 644, y2: 344, color: C.muted });
  arrow(slide, ctx, { x1: 922, y1: 252, x2: 996, y2: 213, color: C.muted });
  arrow(slide, ctx, { x1: 922, y1: 344, x2: 996, y2: 337, color: C.muted });
  arrow(slide, ctx, { x1: 1090, y1: 386, x2: 1090, y2: 452, color: C.muted });

  footer(slide, ctx, 10);
  return slide;
}
