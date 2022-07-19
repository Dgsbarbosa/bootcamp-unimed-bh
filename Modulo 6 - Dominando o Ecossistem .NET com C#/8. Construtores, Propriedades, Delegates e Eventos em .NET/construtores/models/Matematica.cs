using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construtores.models
{
    public class Matematica
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;

            Y = y;

            CalculadoraEvento.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            CalculadoraEvento.Somar(X,Y);
            CalculadoraEvento.Multiplicação(X,Y);                    
        }

        public void EventHandler()
        {
            System.Console.WriteLine("Método executado\n");
        }
    }
}