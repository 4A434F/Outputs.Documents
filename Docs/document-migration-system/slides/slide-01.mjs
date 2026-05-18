import { C, bg, title, footer, node, chip, arrow } from "./theme.mjs";

export async function slide01(presentation, ctx) {
  const slide = presentation.slides.add();
  bg(slide, ctx, "dark");
  title(slide, ctx, "migration solution", "Document outputs become a repeatable system", {
    dark: true,
    width: 850,
    height: 44,
    size: 36,
    note: "From legacy assets to typed contracts, templates, and PDF execution."
  });

  const y = 290;
  const boxes = [
    ["Legacy files", "copybooks\nprograms\noverlays", C.amberSoft, C.amber],
    ["Doc ID report", "fields\nsections\nstructure", C.blueSoft, C.blue],
    ["Developer build", "contract\ntemplate\ntests", C.tealSoft, C.teal],
    ["Execution", "endpoint\nbutton\nbatch", C.greenSoft, C.green],
    ["PDF output", "selected\nrendered\nvalidated", C.redSoft, C.red]
  ];
  boxes.forEach(([label, sub, fill, accent], i) => {
    const x = 76 + i * 232;
    node(slide, ctx, { x, y, w: 174, h: 114, label, sub, fill, accent, stroke: "#2F3B46" });
    if (i < boxes.length - 1) arrow(slide, ctx, { x1: x + 180, y1: y + 58, x2: x + 226, y2: y + 58, color: "#92A0AD" });
  });

  chip(slide, ctx, { x: 154, y: 526, w: 210, text: "Migration user", fill: "#26323D", color: C.white, stroke: "#3C4A57" });
  chip(slide, ctx, { x: 534, y: 526, w: 210, text: "Developer", fill: "#26323D", color: C.white, stroke: "#3C4A57" });
  chip(slide, ctx, { x: 914, y: 526, w: 210, text: "Execution / API user", fill: "#26323D", color: C.white, stroke: "#3C4A57" });

  ctx.addShape(slide, { left: 180, top: 500, width: 905, height: 1, fill: "#3C4A57", line: ctx.line() });
  footer(slide, ctx, 1);
  return slide;
}
