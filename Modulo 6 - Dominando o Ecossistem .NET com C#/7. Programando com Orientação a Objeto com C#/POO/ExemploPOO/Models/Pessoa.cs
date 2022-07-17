using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string? Nome{get; set;}

        public int Idade{get; set;}

        public string? Documento { get; set; }

        public virtual void Apresentar()
        {   
            if(Nome != null){
            System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, meu documento é {Documento}.");
            }
            else{
                System.Console.WriteLine("Digite um nome valido");
            }           
        }
    }
}