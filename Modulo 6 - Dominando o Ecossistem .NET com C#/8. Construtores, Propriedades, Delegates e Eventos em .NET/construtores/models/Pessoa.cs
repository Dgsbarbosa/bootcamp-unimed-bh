using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construtores.models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        private readonly string cpf = "123456777";

        
        //Contrutor Padrão
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
            cpf = string.Empty;
        }
        


        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;

            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor da classe Pessoa");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }
    }
}