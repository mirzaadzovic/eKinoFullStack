// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Header responsive slide
$("#hamburger").click(function () {
    $(".meni").slideToggle();
});

window.addEventListener("resize", () => {
    if (window.innerWidth > 600)
        document.querySelector(".meni").style.display = "flex";
});



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

function prikaziSliku() {

    var url = document.getElementById("input-film-slika").value;
    var http = new XMLHttpRequest();

    http.onload = () => {
        if (http.status != 404) {
            console.log("ima")
            document.querySelector(".input-slika img").src = url;
        }else {
            console.log("nema");
            document.querySelector(".input-slika img").src = "https://gooloc.com/wp-content/uploads/vector/36/rnoquhaqlke.jpg";
        }

    };

    http.open('GET', url, false);
    http.send();

}
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