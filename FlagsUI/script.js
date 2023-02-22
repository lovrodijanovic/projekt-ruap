const saveButton = document.querySelector("#btnSave");
const barsInput = document.querySelector("#bars");
const stripesInput = document.querySelector("#stripes");
const coloursInput = document.querySelector("#colours");
const redInput = document.querySelector("#red");
const greenInput = document.querySelector("#green");
const blueInput = document.querySelector("#blue");
const goldInput = document.querySelector("#gold");
const whiteInput = document.querySelector("#white");
const blackInput = document.querySelector("#black");
const orangeInput = document.querySelector("#orange");
const mainhueInput = document.querySelector("#mainhue");
const circlesInput = document.querySelector("#circles");
const crossesInput = document.querySelector("#crosses");
const saltiresInput = document.querySelector("#saltires");
const quartersInput = document.querySelector("#quarters");
const sunstarsInput = document.querySelector("#sunstars");
const crescentInput = document.querySelector("#crescent");
const triangleInput = document.querySelector("#triangle");
const iconInput = document.querySelector("#icon");
const animateInput = document.querySelector("#animate");
const textInput = document.querySelector("#text");
const topleftInput = document.querySelector("#topleft");
const botrightInput = document.querySelector("#botright");
const landmassInput = document.querySelector("#landmass");
const areaInput = document.querySelector("#area");
const languageInput = document.querySelector("#language");
const populationInput = document.querySelector("#population");
const religionInput = document.querySelector("#religion");
const zoneInput = document.querySelector("#zone");
const nameInput = document.querySelector("#flagName");

const flagContainer = document.querySelector("#flags_container");

function addFlag(
  bars,
  stripes,
  colours,
  red,
  green,
  blue,
  gold,
  white,
  black,
  orange,
  mainhue,
  circles,
  crosses,
  saltires,
  quarters,
  sunstars,
  crescent,
  triangle,
  icon,
  animate,
  text,
  topleft,
  botright,
  landmass,
  area,
  language,
  population,
  religion,
  zone,
  flagName
) {
  const body = {
    bars: bars,
    stripes: stripes,
    colours: colours,
    red: red,
    green: green,
    blue: blue,
    gold: gold,
    white: white,
    black: black,
    orange: orange,
    mainhue: mainhue,
    circles: circles,
    crosses: crosses,
    saltires: saltires,
    quarters: quarters,
    sunstars: sunstars,
    crescent: crescent,
    triangle: triangle,
    icon: icon,
    animate: animate,
    text: text,
    topleft: topleft,
    botright: botright,
    landmass: landmass,
    area: area,
    language: language,
    population: population,
    religion: religion,
    zone: zone,
    flagName: flagName,
  };

  fetch("https://localhost:7076/api/flags", {
    method: "POST",
    body: JSON.stringify(body),
    headers: {
      "content-type": "application/json",
    },
  })
    .then((data) => data.json())
    .then((response) => console.log(response));
}

function getFlag() {
  fetch("https://localhost:7076/api/flags")
    .then((data) => data.json())
    .then((response) => displayResults(response));
}

function displayResults(flags) {
  const flagElement = `
    <div class="flag">
      <p>landmass: 1=N.America, 2=S.America, 3=Europe, 4=Africa, 4=Asia, 6=Oceania </p>
      <h3>Result: ${JSON.stringify(
        flags.Results.output1.value.Values[0][29]
      )}</h3>
    </div>
    `;
  flagContainer.innerHTML = flagElement;
}

getFlag();

saveButton.addEventListener("click", function () {
  addFlag(
    bars.value,
    stripes.value,
    colours.value,
    red.value,
    green.value,
    blue.value,
    gold.value,
    white.value,
    black.value,
    orange.value,
    mainhue.value,
    circles.value,
    crosses.value,
    saltires.value,
    quarters.value,
    sunstars.value,
    crescent.value,
    triangle.value,
    icon.value,
    animate.value,
    text.value,
    topleft.value,
    botright.value,
    landmass.value,
    area.value,
    language.value,
    population.value,
    religion.value,
    zone.value,
    flagName.value
  );
});
