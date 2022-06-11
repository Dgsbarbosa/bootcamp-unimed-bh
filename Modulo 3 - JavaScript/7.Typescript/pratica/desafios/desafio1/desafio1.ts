/* Como podemos rodar isso em um arquivo .ts sem causar erros? 

let employee = {};
employee.code = 10;
employee.name = "John";


console.log({employee});

tire os comentarios e veja os erros
*/

//  Solução

interface Employee  {
    code: number,
    name : string

};

const funcionario1 : Employee = {
    code: 230, 
    name: 'Douglas'

}


console.log(funcionario1);



