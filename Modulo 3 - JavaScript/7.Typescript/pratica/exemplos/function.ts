/*

*/

//criando tipo com type

type input = number| string

function somarValores(input1: input, input2: input){
    if(typeof input1 === "string" || typeof input2 === "string"){
        return input1.toString() + input2.toString()
    }
    else{
        return input1 + input2
    }
}

console.log(`Somando = ${somarValores(1,5)}`);
console.log(`Aceita string tambem`);
console.log(`Concatenando uma string com um number ${somarValores("1",5)}`);


// Definir o tipo e proteger o tipo variavel na função

function somarValores2(numero1: number, numero2: number):number{
    return numero1 + numero2
}

//Usando Void: nao retorna nada

function printaValores(numero1:number,numero2:number):void{
    console.log(numero1+numero2);
    
}


//Inserindo Callbacks em função

function somarValoresETratar(numero1: number, numero2: number, callback:(numero: number)=>number):number{
    let resultado = numero1 + numero2
    return callback(resultado)
    
}

function aoQuadrado( numero:number):number{
    return numero * numero
}



console.log(somarValoresETratar(1,3,aoQuadrado))
