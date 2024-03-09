const svg = document.querySelector("svg");

const svgns = "http://www.w3.org/2000/svg";

// change any value
let width = 120;
let box_width = 64;
let clock_width = 128;
let team_width = 256;
let divider_width = 8;
let height = 64;
let columns = 4;
let rows = 1;
let counter = 0;
let text_shift = 4;
const colorArray = ["#94c356", "#46a4cc", "#a63e4b"];

const scorebug_width_profile = [team_width, divider_width, box_width, divider_width, team_width, divider_width, box_width, divider_width, box_width]
const scorebug_width = 2 * team_width + 3 * box_width + 4 * divider_width + clock_width;

// figure the new svg width/height
const svgWidth = scorebug_width;
const svgHeight = height * rows;

gsap.set(svg, {
  attr: {
    width: svgWidth,
    height: svgHeight,
    viewBox: "0 0 " + svgWidth + " " + svgHeight
  }
});
var scorebug_width_track = 0
let awaybox = document.createElementNS(svgns, "rect");
gsap.set(awaybox, {
  x: scorebug_width_track,
  y: 0,
  width: team_width,
  height: height,
  fill: "#ff0000"
});
svg.appendChild(awaybox);
let away = document.createElementNS(svgns, "text");
svg.appendChild(away);
gsap.set(away, {
  x: scorebug_width_track + team_width / 2,
  y: height / 2 + text_shift
});
var scorebug_width_track = scorebug_width_track + team_width;
away.textContent = scorebug_width_track;
let awaygoalbox = document.createElementNS(svgns, "rect");
gsap.set(awaygoalbox, {
  x: scorebug_width_track,
  y: 0,
  width: box_width,
  height: height,
  fill: "#eee"
});
svg.appendChild(awaygoalbox);
let awaygoals = document.createElementNS(svgns, "text");
svg.appendChild(awaygoals);
gsap.set(awaygoals, {
  x: scorebug_width_track + box_width / 2,
  y: height / 2 + text_shift,
  fill: "black"
});
awaygoals.textContent = scorebug_width_track;
var scorebug_width_track = scorebug_width_track + box_width;
let d2 = document.createElementNS(svgns, "rect");
gsap.set(d2, {
  x: scorebug_width_track,
  y: 0,
  width: divider_width,
  height: height,
  fill: "#000000"
});
var scorebug_width_track = scorebug_width_track + divider_width;
svg.appendChild(d2);
let homebox = document.createElementNS(svgns, "rect");
gsap.set(homebox, {
  x: scorebug_width_track,
  y: 0,
  width: team_width,
  height: height,
  fill: "#ff0000"
});
svg.appendChild(homebox);
let home = document.createElementNS(svgns, "text");
svg.appendChild(home);
gsap.set(home, {
  x: scorebug_width_track + team_width / 2,
  y: height / 2 + text_shift
});
var scorebug_width_track = scorebug_width_track + team_width;
home.textContent = scorebug_width_track;
let homegoalbox = document.createElementNS(svgns, "rect");
gsap.set(homegoalbox, {
  x: scorebug_width_track,
  y: 0,
  width: box_width,
  height: height,
  fill: "#eee"
});
svg.appendChild(homegoalbox);
let homegoals = document.createElementNS(svgns, "text");
svg.appendChild(homegoals);
gsap.set(homegoals, {
  x: scorebug_width_track + box_width / 2,
  y: height / 2 + text_shift,
  fill: "black"
});
homegoals.textContent = scorebug_width_track;
var scorebug_width_track = scorebug_width_track + box_width;
let d4 = document.createElementNS(svgns, "rect");
gsap.set(d4, {
  x: scorebug_width_track,
  y: 0,
  width: divider_width,
  height: height,
  fill: "#000000"
});
var scorebug_width_track = scorebug_width_track + divider_width;
svg.appendChild(d4);
let periodbox = document.createElementNS(svgns, "rect");
gsap.set(periodbox, {
  x: scorebug_width_track,
  y: 0,
  width: box_width,
  height: height,
  fill: "#666"
});
svg.appendChild(periodbox);
let perioddisplay = document.createElementNS(svgns, "text");
svg.appendChild(perioddisplay);
gsap.set(perioddisplay, {
  x: scorebug_width_track + box_width / 2,
  y: height / 2 + text_shift
});
perioddisplay.textContent = "1st";
var scorebug_width_track = scorebug_width_track + box_width;
let clockbox = document.createElementNS(svgns, "rect");
gsap.set(clockbox, {
  x: scorebug_width_track,
  y: 0,
  width: clock_width,
  height: height,
  fill: "#333"
});
svg.appendChild(clockbox);
let clockdisplay = document.createElementNS(svgns, "text");
svg.appendChild(clockdisplay);
gsap.set(clockdisplay, {
  x: scorebug_width_track + clock_width / 2,
  y: height / 2 + text_shift
});
svg.appendChild(clockdisplay);
clockdisplay.textContent = "20:00";