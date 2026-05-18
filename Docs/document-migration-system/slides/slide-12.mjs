import { C, bg, title, footer, node, arrow, chip } from "./theme.mjs";

export async function slide12(presentation, ctx) {
  const slide = presentation.slides.add();
  bg(slide, ctx, "dark");
  title(slide, ctx, "operating model", "The result is a document migration factory", {
    dark: true,
    note: "One flow for migration, one flow for development, one flow for execution."
  });

  ctx.addShape(slide, { left: 94, top: 252, width: 1040, height: 6, fill: "#526170", line: ctx.line() });
  const waves = [
    ["Wave 1", "FSCD cancellation", "BGOW0044 variants\nshared letter components", C.red],
    ["Wave 2", "Document families", "repeat reports\nreuse domains/components", C.blue],
    ["Wave 3", "Execution channels", "API endpoints\ndashboard buttons\nbatch runs", C.green]
  ];
  waves.forEach(([wave, label, sub, accent], i) => {
    const x = 134 + i * 356;
    ctx.addShape(slide, { left: x, top: 224, width: 62, height: 62, fill: accent, line: ctx.line() });
    ctx.addText(slide, { text: String(i + 1), left: x, top: 236, width: 62, height: 34, fontSize: 28, bold: true, color: C.white, align: "center", insets: { left: 0, right: 0, top: 0, bottom: 0 } });
    node(slide, ctx, { x: x - 40, y: 328, w: 260, h: 120, label, sub, fill: "#1E2934", stroke: "#384758", color: C.white, accent });
    chip(slide, ctx, { x: x - 40, y: 476, w: 108, text: wave, fill: accent, color: C.white, stroke: accent });
  });

  arrow(slide, ctx, { x1: 354, y1: 388, x2: 440, y2: 388, color: "#92A0AD" });
  arrow(slide, ctx, { x1: 710, y1: 388, x2: 796, y2: 388, color: "#92A0AD" });

  ctx.addShape(slide, { left: 120, top: 580, width: 1040, height: 56, fill: "#1E2934", line: ctx.line("#384758", 1) });
  ctx.addText(slide, {
    text: "Repeatable reports + typed templates + provider-independent rendering",
    left: 150,
    top: 598,
    width: 980,
    height: 22,
    fontSize: 17,
    bold: true,
    color: C.white,
    align: "center",
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });

  footer(slide, ctx, 12);
  return slide;
}
