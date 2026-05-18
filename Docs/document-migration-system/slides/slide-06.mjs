import { C, bg, title, footer, node, arrow } from "./theme.mjs";

export async function slide06(presentation, ctx) {
  const slide = presentation.slides.add();
  bg(slide, ctx);
  title(slide, ctx, "template metadata", "The developer fills a small contract so the system can discover and run it");

  ctx.addShape(slide, { left: 344, top: 162, width: 592, height: 388, fill: C.dark2, line: ctx.line() });
  ctx.addText(slide, {
    text: "@attribute [DocumentTemplate(\n  Key = \"fs1176-life-non-payment\",\n  Name = \"FS1176 cancellation letter\",\n  Group = \"FSCD\")]\n\n<LetterLayout ...>\n  <BodyContent>...</BodyContent>\n</LetterLayout>\n\n@code {\n  [Parameter] public BGOW0044Contract Model { get; set; }\n}",
    left: 382,
    top: 202,
    width: 520,
    height: 300,
    fontSize: 17,
    color: "#EAF0F6",
    typeface: ctx.fonts.mono,
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });

  const callouts = [
    { x: 86, y: 190, label: "Key", sub: "stable technical id", accent: C.red, edgeX: 344 },
    { x: 86, y: 318, label: "Name", sub: "human-readable label", accent: C.blue, edgeX: 344 },
    { x: 86, y: 446, label: "Group", sub: "document family", accent: C.teal, edgeX: 344 },
    { x: 990, y: 234, label: "Model", sub: "typed input contract", accent: C.green, edgeX: 956 },
    { x: 990, y: 378, label: "Layout", sub: "shared print structure", accent: C.amber, edgeX: 956 }
  ];
  callouts.forEach((c) => {
    node(slide, ctx, { x: c.x, y: c.y, w: 198, h: 78, label: c.label, sub: c.sub, fill: C.white, accent: c.accent });
    arrow(slide, ctx, { x1: c.x < 500 ? c.x + 202 : c.x - 6, y1: c.y + 39, x2: c.edgeX, y2: c.y + 39, color: c.accent });
  });

  footer(slide, ctx, 6);
  return slide;
}
