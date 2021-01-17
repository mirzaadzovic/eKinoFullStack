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

//REZERVACIJA SJEDIŠTA PRIKAZ
function rezervisiSjedista(ponuda) {
    document.getElementById("shadow-box").style.zIndex = "3";
    document.getElementById("shadow-box").style.height = "100%";
    document.querySelector(".seats-container").style.opacity = "1";

    prikaziSjedista(ponuda);
}

function rezervacijaZatvori() {
    document.getElementById("shadow-box").style.zIndex = "-1";
    document.getElementById("shadow-box").style.height = "0%";
    document.querySelector(".seats-container").style.opacity = "0";
}

function prikaziSjedista(ponuda) {
    let url = "/Sjedista/Rezervisi?Ponuda=" + ponuda;
    let forma = $(".seats-container");

    $.get(url, function (data) {
        forma.html(data);

        generisiRaspored(ponuda);

    });
}
//generiše kvadratiće sjedišta asinhrono
function generisiRaspored(id) {
    var url = "/Sjedista/Prikaz?TerminID=" + id;
    $.get(url, function (data) {
        $("#seats-all").html(data);
        //sjedista.js
        inicijalizujSlobodnaSjedista();//ubacuje sjedišta u niz da bi im se dodali eventlisteneri u sjedista.js skripti
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