import { C, bg, title, footer, node, arrow } from "./theme.mjs";

export async function slide08(presentation, ctx) {
  const slide = presentation.slides.add();
  bg(slide, ctx);
  title(slide, ctx, "DocumentRenderer logic", "Runtime uses descriptors and providers, not origin-specific hard-coding");

  node(slide, ctx, { x: 78, y: 230, w: 210, h: 98, label: "IDocumentModel", sub: "+ RenderSource", fill: C.white, accent: C.blue });
  node(slide, ctx, { x: 78, y: 392, w: 210, h: 98, label: "template registry", sub: "precomputed descriptors", fill: C.white, accent: C.violet });

  node(slide, ctx, { x: 390, y: 230, w: 230, h: 260, label: "selector", sub: "rules choose zero or one template\n\nfallback uses default\nconflicts throw clearly", fill: C.blueSoft, stroke: C.blue, accent: C.blue });
  node(slide, ctx, { x: 724, y: 230, w: 230, h: 260, label: "Razor HTML", sub: "body template\noptional header\noptional footer", fill: C.tealSoft, stroke: C.teal, accent: C.teal });
  node(slide, ctx, { x: 1050, y: 230, w: 150, h: 260, label: "PDF provider", sub: "IronPDF today\nreplaceable later", fill: C.greenSoft, stroke: C.green, accent: C.green });

  arrow(slide, ctx, { x1: 294, y1: 279, x2: 384, y2: 279, color: C.muted });
  arrow(slide, ctx, { x1: 294, y1: 441, x2: 384, y2: 441, color: C.muted });
  arrow(slide, ctx, { x1: 626, y1: 360, x2: 718, y2: 360, color: C.muted });
  arrow(slide, ctx, { x1: 960, y1: 360, x2: 1044, y2: 360, color: C.muted });

  ctx.addShape(slide, { left: 388, top: 552, width: 812, height: 52, fill: C.dark2, line: ctx.line() });
  ctx.addText(slide, {
    text: "Core rendering does not know FSCD, DOCE, copybooks, or concrete origin families",
    left: 414,
    top: 568,
    width: 760,
    height: 20,
    fontSize: 15,
    bold: true,
    color: C.white,
    align: "center",
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });

  footer(slide, ctx, 8);
  return slide;
}
