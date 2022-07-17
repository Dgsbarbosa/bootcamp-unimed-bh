using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public  class Professor : Pessoa
    {
        public double Salario {get; set;}
        
         public sealed override void Apresentar()
        {   
            if(Nome != null){
            System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. Sou professor e tenho um salario de R$ {Salario},00");
            }
            else{
                System.Console.WriteLine("Digite um nome valido");
            }           
        }
    }
}