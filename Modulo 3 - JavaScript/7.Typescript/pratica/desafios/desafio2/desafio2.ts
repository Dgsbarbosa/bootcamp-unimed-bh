/* Como podemos melhorar o esse código usando TS? 

let pessoa1 = {};
pessoa1.nome = "maria";
pessoa1.idade = 29;
pessoa1.profissao = "atriz"

let pessoa2 = {}
pessoa2.nome = "roberto";
pessoa2.idade = 19;
pessoa2.profissao = "Padeiro";

let pessoa3 = {
    nome: "laura",
    idade: "32",
    profissao: "Atriz"
};

let pessoa4 = {
    nome = "carlos",
    idade = 19,
    profissao = "padeiro"
}*/

interface Pessoas  {
    nome: string,
    idade: number,
    profissao: Profissao

}
enum Profissao{
    Padeiro,
    Empresaria
  
}

let pessoa1 : Pessoas ={
    nome : "Eduarda",
    idade : 29,
    profissao: Profissao.Empresaria 
}

let pessoa2 : Pessoas ={
    nome : "Roberto",
    idade : 19,
    profissao: Profissao.Padeiro 
}

let pessoa3 : Pessoas = {
    nome: "laura",
    idade: 32,
    profissao: Profissao.Empresaria
};

let pessoa4 : Pessoas = {
    nome :"Carlos",
    idade : 19,
    profissao : Profissao.Padeiro
}

console.log(pessoa1)
console.log(pessoa2)
console.log(pessoa3)
console.log(pessoa4)
