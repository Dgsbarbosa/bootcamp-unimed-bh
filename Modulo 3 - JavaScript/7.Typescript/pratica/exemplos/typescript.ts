
// criando um tipo usand enum
console.log("Trabalhando com objetos");


enum Profissao{
    Professora,
    Atriz,
    Desenvolvedora,
    Cozinheira,
    Design
}



// Criando uma interface

interface Pessoa {
    nome : string,
    idade : number,
    profissao: Profissao
}

interface Estudante extends Pessoa{

}

//criando contantem com o objeto

const douglas : Pessoa = {
    nome:"Douglas",
    idade: 34,
    profissao: Profissao.Desenvolvedora

}

const sabrina : Pessoa = {
    nome: "Sabrina",
    idade: 29,
    profissao: Profissao.Design
}

console.log(douglas, sabrina )

/*
Trabalhando com Any
    Any recebe qualquer tipo

*/

let valorAny:any;

valorAny = 3
valorAny = 'ola'
valorAny = true;