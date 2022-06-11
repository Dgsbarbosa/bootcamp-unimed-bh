"use strict";
/*

*/
function somarValores(input1, input2) {
    if (typeof input1 === "string" || typeof input2 === "string") {
        return input1.toString() + input2.toString();
    }
    else {
        return input1 + input2;
    }
}
console.log(`Somando = ${somarValores(1, 5)}`);
console.log(`Aceita string tambem`);
console.log(`Concatenando uma string com um number ${somarValores("1", 5)}`);
// Definir o tipo e proteger o tipo variavel na função
function somarValores2(numero1, numero2) {
    return numero1 + numero2;
}
//Usando Void: nao retorna nada
function printaValores(numero1, numero2) {
    console.log(numero1 + numero2);
}
//Inserindo Callbacks em função
function somarValoresETratar(numero1, numero2, callback) {
    let resultado = numero1 + numero2;
    return callback(resultado);
}
function aoQuadrado(numero) {
    return numero * numero;
}
console.log(somarValoresETratar(1, 3, aoQuadrado));
