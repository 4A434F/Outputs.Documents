import { C, bg, title, footer, node, arrow } from "./theme.mjs";

export async function slide05(presentation, ctx) {
  const slide = presentation.slides.add();
  bg(slide, ctx);
  title(slide, ctx, "developer user flow", "Build one document by following the report, not rediscovering the legacy system");

  ctx.addShape(slide, { left: 506, top: 250, width: 268, height: 146, fill: C.dark2, line: ctx.line() });
  ctx.addText(slide, {
    text: "renderable\nRazor document",
    left: 530,
    top: 288,
    width: 220,
    height: 64,
    fontSize: 25,
    bold: true,
    color: C.white,
    align: "center",
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });

  const items = [
    { x: 108, y: 174, label: "choose contract", sub: "domain model from report", accent: C.blue },
    { x: 468, y: 142, label: "create template", sub: "Razor component", accent: C.teal },
    { x: 846, y: 174, label: "fill metadata", sub: "key, name, group, model", accent: C.violet },
    { x: 846, y: 462, label: "selection rule", sub: "document id chooses type", accent: C.red },
    { x: 468, y: 500, label: "run tests", sub: "samples, HTML, PDF", accent: C.green },
    { x: 108, y: 462, label: "compose parts", sub: "layout, address, signature", accent: C.amber }
  ];
  items.forEach((item) => node(slide, ctx, { ...item, w: 244, h: 84, fill: C.white }));

  arrow(slide, ctx, { x1: 352, y1: 216, x2: 462, y2: 184, color: C.muted });
  arrow(slide, ctx, { x1: 712, y1: 184, x2: 840, y2: 216, color: C.muted });
  arrow(slide, ctx, { x1: 968, y1: 258, x2: 968, y2: 456, color: C.muted });
  arrow(slide, ctx, { x1: 846, y1: 504, x2: 718, y2: 536, color: C.muted });
  arrow(slide, ctx, { x1: 468, y1: 536, x2: 352, y2: 504, color: C.muted });
  arrow(slide, ctx, { x1: 230, y1: 462, x2: 230, y2: 258, color: C.muted });

  footer(slide, ctx, 5);
  return slide;
}
