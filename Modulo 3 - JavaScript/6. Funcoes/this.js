function calculaIdade(anos) {
	return `Daqui a ${anos} anos, ${this.nome} terá ${
		this.idade + anos
	} anos de idade.`;
}

const pessoa1 = {
    nome: "Maria",
    idade: 30
}

const pessoa2 = {
    nome: "Carla",
    idade: 30
}

const animal = {
    nome: "Fiona",
    idade: 5,
    raca: "Pug"
}

console.log("Dando console log com Call"); 
console.log(calculaIdade.call(animal,7));

console.log("\nDando console log com Apply"); 
console.log(calculaIdade.apply(pessoa1,[7]));

