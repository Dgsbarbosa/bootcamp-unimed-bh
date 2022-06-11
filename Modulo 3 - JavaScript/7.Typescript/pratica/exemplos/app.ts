/*
    Any recebe qualquer valor
*/
let anyEstaDeVolta:any

/*
 Unknown
    Diferente do any, o unknown necessita de validação para rodar, como um if
*/
let unknownValor: unknown

/*
Tipo never um codigo que nao para
*/

function jogaErro(erro: string, codigo: number): never{
    throw {error: erro, code: codigo};
}

jogaErro('deu erro', 800)