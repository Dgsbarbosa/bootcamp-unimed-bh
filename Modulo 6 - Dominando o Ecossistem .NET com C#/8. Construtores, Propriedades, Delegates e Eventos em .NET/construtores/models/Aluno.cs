using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construtores.models
{
    // Herdando da classe Pessoa
    public class Aluno : Pessoa
    {
        //recebendo os parametros iguais da classe mae e passando os parametros para a clase mae atrave do base
        public Aluno (string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            
            System.Console.WriteLine("Construtor da classe Aluno");
        }
    }
}