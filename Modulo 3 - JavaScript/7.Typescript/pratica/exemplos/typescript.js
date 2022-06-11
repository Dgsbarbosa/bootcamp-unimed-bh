"use strict";
// criando um tipo usand enum
console.log("Trabalhando com objetos");
var Profissao;
(function (Profissao) {
    Profissao[Profissao["Professora"] = 0] = "Professora";
    Profissao[Profissao["Atriz"] = 1] = "Atriz";
    Profissao[Profissao["Desenvolvedora"] = 2] = "Desenvolvedora";
    Profissao[Profissao["Cozinheira"] = 3] = "Cozinheira";
    Profissao[Profissao["Design"] = 4] = "Design";
})(Profissao || (Profissao = {}));
//criando contantem com o objeto
const douglas = {
    nome: "Douglas",
    idade: 34,
    profissao: Profissao.Desenvolvedora
};
const sabrina = {
    nome: "Sabrina",
    idade: 29,
    profissao: Profissao.Design
};
console.log(douglas, sabrina);
/*
Trabalhando com Any
    Any recebe qualquer tipo

*/
let valorAny;
valorAny = 3;
valorAny = 'ola';
valorAny = true;
