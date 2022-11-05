// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function sleep(milliseconds) {
  var start = new Date().getTime();
  for (var i = 0; i < 1e7; i++) {
    if (new Date().getTime() - start > milliseconds) {
      break;
    }
  }
}

function showAlert(i) {
  let pistaNum = "pista" + i.toString();
  let pista1 = document.getElementById(pistaNum).value;
  let alert = document.getElementById("alertbox");
  let buttonClosing = `<button type="button" class="close" data-dismiss="alert" aria-label="Close">
    <span aria-hidden="true">&times;</span>
  </button>`;
  alert.innerHTML = pista1 + " " + buttonClosing;

  alert.style.display = "inline-block";
}

function formValidation1(sala) {
  input = document.getElementById("ans").value;
  ans = input.toString().toLowerCase();

  index = sala - 1;
  nombres = ["Rial", "Mirtha", "Scaloni", "Maradona"];
  respuestas1 = ["jorge rial", "jorge", "rial"];
  respuestas2 = ["1927-02-23"];
  respuestas3 = [
    "scaloni",
    "lionel scaloni",
    "lionel",
    "scaloneta",
    "la scaloneta",
    "fulbo shampan",
  ];
  respuestas4 = ["#1d0656"];
  if (
    (respuestas1.includes(ans) && sala == 1) ||
    (respuestas2.includes(ans) && sala == 2) ||
    (respuestas3.includes(ans) && sala == 3) ||
    (respuestas4.includes(ans) && sala == 4)
  ) {
    let path = "../img/siluetas/" + nombres[index] + "_Color.png";
    let fotoDiv = document.getElementById("fotuli");

    fotoDiv.innerHTML = `<img src=${path} style="width: 100%;" alt="Personaje 1">`;
    var audio = new Audio("../img/yay.mp3");
    audio.play();
  } else {
    var audio = new Audio("../img/nashe.mp3");
    audio.play();
  }
}

function inputFinal() {
  const equals = (a, b) => JSON.stringify(a) === JSON.stringify(b);
  input = [];
  respuestaCorrecta = [3, 0, 7, 5];
  for (let i = 0; i < 4; i++) {
    input[i] = parseInt(document.getElementById("input" + (i + 1)).value);
  }
  console.log(input);
  if (equals(respuestaCorrecta, input)) {
    fotuliDiv = document.getElementById("fotuli");
    fotuliDiv.innerHTML = `<img src="../img/caja_fuerte_abierta.png" class="mb-3" alt="Caja Fuerte">`;
    var audio = new Audio("../img/yay.mp3");
    audio.play();
  } else {
    var audio = new Audio("../img/nashe.mp3");
    audio.play();
  }
}
