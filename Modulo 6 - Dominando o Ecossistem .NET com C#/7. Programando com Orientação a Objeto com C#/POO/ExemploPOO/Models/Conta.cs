using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo;

        //metodo abstrado
        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo é: {saldo}");
        }
    }
}