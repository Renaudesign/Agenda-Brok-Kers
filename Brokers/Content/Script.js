// @ts-check

//Affichage du jour de la semaine
let today_date = new Date()
const weekday = ["Dimanche", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi"]
const month = ["Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"]

let dateday = weekday[today_date.getDay()]
document.getElementById("dateday").innerHTML = dateday

let datetest = today_date.getDate() + " " + month[today_date.getMonth()] + " " + today_date.getFullYear()
document.getElementById("datedaytest").innerHTML = datetest





//Fenêtre modale
const openEls = document.querySelectorAll("[data-open]");
const closeEls = document.querySelectorAll("[data-close]");
const isVisible = "is-visible";

for (const el of openEls) {
    el.addEventListener("click", function (element) {
        let brokerId = this.id;
        let brokerName = this.name;
        document.getElementById("idbroker").setAttribute("value", brokerId);
        document.getElementById("cibleTexte").innerHTML = brokerName;
        const modalId = this.dataset.open;
        document.getElementById(modalId).classList.add(isVisible);
    })
}

for (const el of closeEls) {
    el.addEventListener("click", function () {
        this.parentElement.parentElement.parentElement.classList.remove(isVisible);
    })
}

document.addEventListener("click", e => {
    if (e.target == document.querySelector(".modal.is-visible")) {
        document.querySelector(".modal.is-visible").classList.remove(isVisible);
    }
})

document.addEventListener("keyup", e => {
    // if we press the ESC
    if (e.key == "Escape" && document.querySelector(".modal.is-visible")) {
        document.querySelector(".modal.is-visible").classList.remove(isVisible)
    }
})
