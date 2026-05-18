import { C, bg, title, footer, node, arrow } from "./theme.mjs";

function kit(slide, ctx, x, y, label, color) {
  ctx.addShape(slide, { left: x, top: y, width: 142, height: 70, fill: C.white, line: ctx.line(color, 1.4) });
  ctx.addShape(slide, { left: x, top: y, width: 142, height: 12, fill: color, line: ctx.line() });
  ctx.addText(slide, { text: label, left: x + 10, top: y + 31, width: 122, height: 18, fontSize: 12, bold: true, color: C.ink, align: "center", insets: { left: 0, right: 0, top: 0, bottom: 0 } });
}

export async function slide09(presentation, ctx) {
  const slide = presentation.slides.add();
  bg(slide, ctx);
  title(slide, ctx, "reusable document kit", "Developers compose common print pieces instead of copying layout rules");

  const kits = [
    ["A4 / Letter", C.blue],
    ["Address", C.amber],
    ["Subject / Date", C.teal],
    ["Signature", C.green],
    ["Payment", C.red],
    ["Tables", C.violet]
  ];
  kits.forEach(([label, color], i) => {
    const x = 92 + (i % 3) * 178;
    const y = 208 + Math.floor(i / 3) * 124;
    kit(slide, ctx, x, y, label, color);
  });

  kits.forEach((_, i) => {
    const sx = 92 + (i % 3) * 178 + 150;
    const sy = 208 + Math.floor(i / 3) * 124 + 35;
    const ex = 706;
    const ey = 246 + Math.floor(i / 3) * 124;
    ctx.addShape(slide, { left: sx, top: sy - 1, width: ex - sx, height: 2, fill: "#AEB8C2", line: ctx.line() });
    ctx.addShape(slide, { left: ex, top: Math.min(sy, ey), width: 2, height: Math.abs(ey - sy), fill: "#AEB8C2", line: ctx.line() });
  });

  ctx.addShape(slide, { left: 742, top: 158, width: 330, height: 420, fill: C.white, line: ctx.line(C.line, 1) });
  ctx.addShape(slide, { left: 742, top: 158, width: 330, height: 54, fill: C.dark2, line: ctx.line() });
  ctx.addText(slide, { text: "FSCD Template", left: 772, top: 177, width: 270, height: 18, fontSize: 17, bold: true, color: C.white, align: "center", insets: { left: 0, right: 0, top: 0, bottom: 0 } });
  ctx.addShape(slide, { left: 780, top: 246, width: 254, height: 52, fill: C.amberSoft, line: ctx.line(C.amber, 1) });
  ctx.addShape(slide, { left: 780, top: 314, width: 254, height: 48, fill: C.blueSoft, line: ctx.line(C.blue, 1) });
  ctx.addShape(slide, { left: 780, top: 382, width: 254, height: 78, fill: C.bg2, line: ctx.line(C.line, 1) });
  ctx.addShape(slide, { left: 780, top: 482, width: 116, height: 48, fill: C.greenSoft, line: ctx.line(C.green, 1) });
  ctx.addShape(slide, { left: 918, top: 482, width: 116, height: 48, fill: C.redSoft, line: ctx.line(C.red, 1) });

  ctx.addText(slide, { text: "origin-specific wording stays here", left: 780, top: 606, width: 254, height: 20, fontSize: 13, bold: true, color: C.red, align: "center", insets: { left: 0, right: 0, top: 0, bottom: 0 } });

  footer(slide, ctx, 9);
  return slide;
}
