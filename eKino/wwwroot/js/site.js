// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const dani = document.getElementsByClassName("dan");
for (let i = 0; i < dani.length; i++) {
    dani[i].addEventListener("click", (e) => {
        for (let i = 0; i < dani.length; i++) dani[i].id = "";
        e.target.id = "dan-active";
        console.log(e.target.innerText);
    });
}


//Zakazivanje projekcija radio buttoni
//const slika = document.querySelector("#zakazivanje-container-slika img");
const krajnjiDiv = document.getElementById("krajnji-datum-div");
const naslovFilma = document.querySelector("#zakazivanje-container-slika h2");

//function prikaziSliku(slike) {
//    let filmOdabran = document.querySelector(".film-select");
//    slika.src = filmOdabran.value;
//}
function prikaziNazivFilma() {
    let filmOdabran = document.querySelector(".film-select");
    naslovFilma.innerText = filmOdabran.options[filmOdabran.selectedIndex].text;
}
function omoguciKrajnjiDatum() {
    let radio = document.getElementById("radio-za-danas");
    let input = document.getElementById("krajnji-datum");
    let label = document.getElementById("zakazivanje-datum-od");
    console.log(radio.checked);

    if (radio.checked) {
        input.disabled = true;
        input.value = "";
        label.innerText = "Datum";
        krajnjiDiv.style.opacity = 0;
    } else {
        label.innerText = "Od";
        input.disabled = false;
        krajnjiDiv.style.opacity = 1;
    }
}