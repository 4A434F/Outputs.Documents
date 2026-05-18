export const C = {
  bg: "#F6F7F8",
  bg2: "#EFF3F6",
  ink: "#17202A",
  muted: "#64707D",
  line: "#C7D0D8",
  white: "#FFFFFF",
  red: "#D22630",
  redSoft: "#F9D6DA",
  blue: "#2B6CB0",
  blueSoft: "#DCEBFA",
  teal: "#1E7A73",
  tealSoft: "#DDF1EF",
  green: "#2F855A",
  greenSoft: "#DFF2E7",
  amber: "#B7791F",
  amberSoft: "#F6E8C3",
  violet: "#6B46C1",
  violetSoft: "#E9E1FA",
  dark: "#101820",
  dark2: "#1F2933"
};

export function bg(slide, ctx, variant = "light") {
  const fill = variant === "dark" ? C.dark : C.bg;
  ctx.addShape(slide, { left: 0, top: 0, width: ctx.W, height: ctx.H, fill, line: ctx.line() });
  if (variant !== "dark") {
    ctx.addShape(slide, { left: 0, top: 0, width: 18, height: ctx.H, fill: C.red, line: ctx.line() });
    ctx.addShape(slide, { left: 18, top: 0, width: 5, height: ctx.H, fill: C.blue, line: ctx.line() });
  } else {
    ctx.addShape(slide, { left: 0, top: 0, width: 18, height: ctx.H, fill: C.red, line: ctx.line() });
    ctx.addShape(slide, { left: 18, top: 0, width: 5, height: ctx.H, fill: C.teal, line: ctx.line() });
  }
}

export function title(slide, ctx, kicker, headline, opts = {}) {
  const color = opts.dark ? C.white : C.ink;
  const muted = opts.dark ? "#AEB8C2" : C.muted;
  ctx.addText(slide, {
    text: kicker.toUpperCase(),
    left: 62,
    top: 34,
    width: 360,
    height: 18,
    fontSize: 11,
    bold: true,
    color: opts.accent || C.red,
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });
  ctx.addText(slide, {
    text: headline,
    left: 62,
    top: 58,
    width: opts.width || 860,
    height: opts.height || (opts.note ? 44 : 70),
    fontSize: opts.size || 32,
    bold: true,
    color,
    typeface: ctx.fonts.title,
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });
  if (opts.note) {
    ctx.addText(slide, {
      text: opts.note,
      left: 62,
      top: opts.noteTop || 116,
      width: 700,
      height: 24,
      fontSize: 14,
      color: muted,
      insets: { left: 0, right: 0, top: 0, bottom: 0 }
    });
  }
}

export function footer(slide, ctx, n) {
  ctx.addText(slide, {
    text: String(n).padStart(2, "0"),
    left: 1160,
    top: 660,
    width: 48,
    height: 20,
    fontSize: 11,
    bold: true,
    color: C.muted,
    align: "right",
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });
}

export function node(slide, ctx, { x, y, w, h, label, sub, fill = C.white, stroke = C.line, color = C.ink, accent, icon }) {
  ctx.addShape(slide, { left: x, top: y, width: w, height: h, fill, line: ctx.line(stroke, 1) });
  if (accent) ctx.addShape(slide, { left: x, top: y, width: 6, height: h, fill: accent, line: ctx.line() });
  if (icon) {
    ctx.addText(slide, {
      text: icon,
      left: x + 16,
      top: y + 14,
      width: 34,
      height: 34,
      fontSize: 24,
      color: accent || color,
      align: "center",
      insets: { left: 0, right: 0, top: 0, bottom: 0 }
    });
  }
  const tx = icon ? x + 60 : x + 18;
  ctx.addText(slide, {
    text: label,
    left: tx,
    top: y + 15,
    width: w - (icon ? 78 : 36),
    height: sub ? 24 : h - 26,
    fontSize: 16,
    bold: true,
    color,
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });
  if (sub) {
    ctx.addText(slide, {
      text: sub,
      left: tx,
      top: y + 42,
      width: w - (icon ? 78 : 36),
      height: Math.max(18, h - 58),
      fontSize: 11,
      color: C.muted,
      insets: { left: 0, right: 0, top: 0, bottom: 0 }
    });
  }
}

export function chip(slide, ctx, { x, y, w, text, fill = C.bg2, color = C.ink, stroke = C.line }) {
  ctx.addShape(slide, { left: x, top: y, width: w, height: 30, fill, line: ctx.line(stroke, 1) });
  ctx.addText(slide, {
    text,
    left: x,
    top: y + 6,
    width: w,
    height: 18,
    fontSize: 11,
    bold: true,
    color,
    align: "center",
    insets: { left: 4, right: 4, top: 0, bottom: 0 }
  });
}

export function arrow(slide, ctx, { x1, y1, x2, y2, color = C.line, label }) {
  const horizontal = Math.abs(x2 - x1) >= Math.abs(y2 - y1);
  if (horizontal) {
    const left = Math.min(x1, x2);
    const w = Math.abs(x2 - x1);
    ctx.addShape(slide, { left, top: y1 - 1, width: w - 10, height: 2, fill: color, line: ctx.line() });
    ctx.addText(slide, {
      text: x2 >= x1 ? "›" : "‹",
      left: x2 >= x1 ? x2 - 14 : x2 + 2,
      top: y1 - 16,
      width: 18,
      height: 28,
      fontSize: 30,
      bold: true,
      color,
      align: "center",
      insets: { left: 0, right: 0, top: 0, bottom: 0 }
    });
  } else {
    const top = Math.min(y1, y2);
    const h = Math.abs(y2 - y1);
    ctx.addShape(slide, { left: x1 - 1, top, width: 2, height: h - 10, fill: color, line: ctx.line() });
    ctx.addText(slide, {
      text: y2 >= y1 ? "⌄" : "⌃",
      left: x1 - 10,
      top: y2 >= y1 ? y2 - 20 : y2 + 2,
      width: 20,
      height: 20,
      fontSize: 20,
      bold: true,
      color,
      align: "center",
      insets: { left: 0, right: 0, top: 0, bottom: 0 }
    });
  }
  if (label) {
    ctx.addText(slide, {
      text: label,
      left: (x1 + x2) / 2 - 64,
      top: (y1 + y2) / 2 - 22,
      width: 128,
      height: 18,
      fontSize: 10,
      color: C.muted,
      align: "center",
      fill: C.bg,
      insets: { left: 3, right: 3, top: 1, bottom: 1 }
    });
  }
}

export function miniPage(slide, ctx, { x, y, w, h, titleText, bands = [] }) {
  ctx.addShape(slide, { left: x + 10, top: y + 10, width: w, height: h, fill: "#D4DAE0", line: ctx.line() });
  ctx.addShape(slide, { left: x, top: y, width: w, height: h, fill: C.white, line: ctx.line(C.line, 1) });
  ctx.addShape(slide, { left: x, top: y, width: w, height: 36, fill: C.dark2, line: ctx.line() });
  ctx.addText(slide, {
    text: titleText,
    left: x + 16,
    top: y + 10,
    width: w - 32,
    height: 16,
    fontSize: 12,
    bold: true,
    color: C.white,
    insets: { left: 0, right: 0, top: 0, bottom: 0 }
  });
  bands.forEach((band, i) => {
    const yy = y + 54 + i * 38;
    ctx.addShape(slide, { left: x + 18, top: yy, width: w - 36, height: 8, fill: band.color || C.blueSoft, line: ctx.line() });
    ctx.addShape(slide, { left: x + 18, top: yy + 16, width: (w - 36) * (band.pct || 0.68), height: 7, fill: "#E6EBEF", line: ctx.line() });
  });
}

export function bandLabel(slide, ctx, { x, y, w, text, color = C.blue }) {
  ctx.addShape(slide, { left: x, top: y, width: w, height: 28, fill: color, line: ctx.line() });
  ctx.addText(slide, {
    text,
    left: x,
    top: y + 7,
    width: w,
    height: 14,
    fontSize: 10,
    bold: true,
    color: C.white,
    align: "center",
    insets: { left: 4, right: 4, top: 0, bottom: 0 }
  });
}
