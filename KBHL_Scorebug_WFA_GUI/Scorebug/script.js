import { gsap } from "gsap";

// targeting the svg itself
const svg = document.querySelector("svg");

// variable for the namspace
const svgns = "http://www.w3.org/2000/svg";

// make simple rectangles
let newRect1 = document.createElementNS(svgns, "rect");
let newRect2 = document.createElementNS(svgns, "rect");

// set attributes of new rectangles
gsap.set(newRect1, {
  attr: {
    x: 50,
    y: 150,
    width: 100,
    height: 100,
    fill: "#5cceee",
    class: "target"
  }
});
gsap.set(newRect2, {
  attr: { x: 250, y: 150, width: 100, height: 100, class: "target" },
  fill: "#5cceee"
});

// append the new rectangles to the svg
svg.appendChild(newRect1);
svg.appendChild(newRect2);

