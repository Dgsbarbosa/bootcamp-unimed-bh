using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construtores.models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            if(mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
            
        }  
        public void ApresentarMes()
        {
            if(this.mesValido)
            {
                System.Console.WriteLine($"Você escolheu o mês: {this.mes}");
            }
            else
            {
                System.Console.WriteLine("Mês invalido");
                System.Console.WriteLine("Escolha um mês válido");
            }
            
        }
        
    }
}