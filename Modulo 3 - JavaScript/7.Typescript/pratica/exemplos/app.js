"use strict";
/*
    Any recebe qualquer valor
*/
let anyEstaDeVolta;
/*
 Unknown
    Diferente do any, o unknown necessita de validação para rodar, como um if
*/
let unknownValor;
/*
Tipo never um codigo que nao para
*/
function jogaErro(erro, codigo) {
    throw { error: erro, code: codigo };
}
jogaErro('deu erro', 800);
