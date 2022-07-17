using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota {get; set;}

        public override void Apresentar()
        {   
            if(Nome != null){
            System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, minha nota foi de {Nota}.");
            }
            else{
                System.Console.WriteLine("Digite um nome valido");
            }           
        } 
    }

    

    
}