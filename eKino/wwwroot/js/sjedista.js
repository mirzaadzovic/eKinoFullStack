
//BIRANJE SJEDIŠTA KVADRATIĆI KLIK
var slobodnaSjedista = null;
var odabranihSjedista = null;
var zaPlatiti = null;
var cijenaKarte = null;
var cijenaZaPlatiti;
var checkboxoviSjedista = null;
var sjedista=null;




function inicijalizujSlobodnaSjedista() {
    slobodnaSjedista = document.getElementsByClassName("seat");
    odabranihSjedista = document.getElementById("ukupno-sjedista");
    zaPlatiti = document.getElementById("za-platiti-span");
    cijenaKarte = document.getElementById("cijena-karte");
    checkboxoviSjedista = document.querySelectorAll(".seats-row input");


    //Na svako slobodno sjediste dodajemo event listener na klik
    for (let i = 0; i < slobodnaSjedista.length; i++) {
        slobodnaSjedista[i].addEventListener("click", (e) => {
            //console.log(e.target.innerHTML);
            if (e.target.className == "seat") {
                e.target.classList.remove("seat");
                e.target.classList.add("seat-odabrano");

                odabranihSjedista.innerText++;
                zaPlatiti.innerText =
                    parseFloat(zaPlatiti.innerText) + parseFloat(cijenaKarte.innerText);
            } else {
                e.target.classList.remove("seat-odabrano");
                e.target.classList.add("seat");

                odabranihSjedista.innerText--;
                zaPlatiti.innerText =
                    parseFloat(zaPlatiti.innerText) - parseFloat(cijenaKarte.innerText);
            }
            provjeriDugme();
        });
    }
}

function ponistiOdabranaSjedista() {
    var odabrana = document.querySelectorAll(".seat-odabrano");

    for (let i = 0; i < odabrana.length; i++) {
        odabrana[i].classList.remove("seat-odabrano");
        odabrana[i].classList.add("seat");
    }
    nulirajSpanove();
    provjeriDugme();
    nulirajCheckBoxove();
}

function nulirajSpanove() {
    odabranihSjedista.innerText = 0;
    zaPlatiti.innerText = 0;
    provjeriDugme();
}
function provjeriDugme() {
    let dugme = document.querySelector("#rezervisi-btn button");
    if (zaPlatiti.innerText == 0) {
        dugme.id = "btn-blocked";
        dugme.disabled = true;
        return false;
    } else {
        dugme.id = "btn-rezervisi";
        dugme.disabled = false;
        return true;
    }
}



