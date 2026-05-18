import { C, bg, title, footer, miniPage, node, arrow } from "./theme.mjs";

export async function slide03(presentation, ctx) {
  const slide = presentation.slides.add();
  bg(slide, ctx);
  title(slide, ctx, "document id report", "One report becomes the handoff between migration and development");

  miniPage(slide, ctx, {
    x: 500,
    y: 154,
    w: 280,
    h: 414,
    titleText: "Doc ID 1176",
    bands: [
      { color: C.blueSoft, pct: 0.86 },
      { color: C.amberSoft, pct: 0.78 },
      { color: C.tealSoft, pct: 0.70 },
      { color: C.greenSoft, pct: 0.82 },
      { color: C.violetSoft, pct: 0.66 },
      { color: C.redSoft, pct: 0.58 },
      { color: C.blueSoft, pct: 0.76 },
      { color: C.greenSoft, pct: 0.62 }
    ]
  });

  const left = [
    ["legacy sources", "copybooks / programs / overlays", C.amber],
    ["field inventory", "input fields and aliases", C.blue],
    ["document sections", "header, body, payment, tables", C.teal]
  ];
  left.forEach(([label, sub, accent], i) => {
    const y = 164 + i * 128;
    node(slide, ctx, { x: 88, y, w: 300, h: 78, label, sub, fill: C.white, accent });
    arrow(slide, ctx, { x1: 392, y1: y + 39, x2: 492, y2: 246 + i * 67, color: accent });
  });

  const right = [
    ["new structure", "contract and domain proposal", C.green],
    ["samples", "representative render data", C.violet],
    ["template plan", "selection and reusable parts", C.red]
  ];
  right.forEach(([label, sub, accent], i) => {
    const y = 164 + i * 128;
    node(slide, ctx, { x: 894, y, w: 300, h: 78, label, sub, fill: C.white, accent });
    arrow(slide, ctx, { x1: 786, y1: 246 + i * 67, x2: 888, y2: y + 39, color: accent });
  });

  ctx.addText(slide, {
    text: "development-ready",
    left: 514,
    top: 604,
    width: 250,
    height: 26,
    fontSize: 13,
    bold: true,
    color: C.red,
    align: "center",
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });
  footer(slide, ctx, 3);
  return slide;
}
