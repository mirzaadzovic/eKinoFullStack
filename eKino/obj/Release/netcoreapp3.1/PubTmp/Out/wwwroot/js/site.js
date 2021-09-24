// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//Header responsive slide
$("#hamburger").click(function () {
    $(".meni").slideToggle();
});

//zatvorena header navigacija po defaultu ako je prozor uži od 600px 
window.addEventListener("resize", () => {
    if (window.innerWidth > 600)
        document.querySelector(".meni").style.display = "flex";
    else
        document.querySelector(".meni").style.display = "none";
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
function provjeriDatumDo() {
    var datum1 = document.getElementById("datumOdabir");
    var datum2 = document.getElementById("krajnji-datum");

    if (datum1.value > datum2.value)
        datum2.value = datum1.value;
    console.log(datum1.value, datum2.value);
}

//TIMEPICKER
//var timepicker = new TimePicker('time', {
//    lang: 'en',
//    theme: 'dark'
//});
//timepicker.on('change', function (evt) {

//    var value = (evt.hour || '00') + ':' + (evt.minute || '00');
//    evt.element.value = value;

//});
//FILM PRETRAGA
function trazi() {
    let query = document.getElementById("search-input").value;
    console.log(query);
    let url = "/Filmovi/Prikaz?query=" + query;
    $.get(url, function (data) {
        $(".zakazivanje-container").html(data);
    });
}