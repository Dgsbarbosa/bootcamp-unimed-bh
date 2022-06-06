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

console.log(verificaPalindromo2('aba'))
