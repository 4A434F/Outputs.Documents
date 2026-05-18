import { C, bg, title, footer, node, arrow } from "./theme.mjs";

export async function slide11(presentation, ctx) {
  const slide = presentation.slides.add();
  bg(slide, ctx);
  title(slide, ctx, "quality gates", "Every migrated document is checked through the same rendering path");

  const gates = [
    ["samples", "model shape", C.blue],
    ["Razor render", "HTML output", C.teal],
    ["PDF render", "print output", C.green],
    ["generated tests", "all samples", C.violet],
    ["preview", "human check", C.red]
  ];

  gates.forEach(([label, sub, accent], i) => {
    const x = 88 + i * 226;
    ctx.addShape(slide, { left: x + 54, top: 242, width: 92, height: 92, fill: accent, line: ctx.line() });
    ctx.addText(slide, { text: "✓", left: x + 54, top: 258, width: 92, height: 54, fontSize: 40, bold: true, color: C.white, align: "center", insets: { left: 0, right: 0, top: 0, bottom: 0 } });
    node(slide, ctx, { x, y: 382, w: 200, h: 84, label, sub, fill: C.white, accent });
    if (i < gates.length - 1) arrow(slide, ctx, { x1: x + 154, y1: 288, x2: x + 226, y2: 288, color: C.muted });
  });

  ctx.addShape(slide, { left: 120, top: 536, width: 1040, height: 52, fill: C.dark2, line: ctx.line() });
  ctx.addText(slide, {
    text: "Samples are not decoration: they are the contract between migration analysis, template work, and render validation.",
    left: 154,
    top: 552,
    width: 972,
    height: 20,
    fontSize: 14,
    bold: true,
    color: C.white,
    align: "center",
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });

  footer(slide, ctx, 11);
  return slide;
}
