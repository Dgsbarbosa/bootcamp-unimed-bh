//solução 1
console.log("Solução 1");
function verificaPalindromo(string){
    if(!string) return 'string inexistente';

    return string.split("").reverse().join("") === string;
    
}

console.log(verificaPalindromo("ovo"))
//Solução 2
console.log("\nSolução 2");

function verificaPalindromo2(string){
    if(!string) return 'string inexistente';
    for(let i = 0; i< string.length/2; i++){
        if(string[i]!== string[string.length - 1 - i]){
            return false;
        }
    }

    return true;
}

console.log(verificaPalindromo2('aba\n'))

let N = 13;
for ( let i = 1; i < 100; i++) {

//TODO: Complete os espaços em branco com uma possível solução para o desafio

	if (i %  N==2) console.log( [i] );
}
