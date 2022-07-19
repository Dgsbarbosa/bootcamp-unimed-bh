using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construtores.models
{
    public class CalculadoraEvento
    {
        //delegate

        public delegate void DelegateCalculadora();

        //evento

        public static event DelegateCalculadora EventoCalculadora;

            public static void Somar(int x, int y)
        {   
             if(EventoCalculadora != null)
            {
            System.Console.WriteLine("Chamando o método Soma");
            System.Console.WriteLine($"{x} + {y} = {x + y} ");
            EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito");
            }
            
        }


           public static void Subtrair(int x, int y)
        {   
            if(EventoCalculadora != null)
            {
            System.Console.WriteLine("Chamando o método Subtração");
            System.Console.WriteLine($"{x} - {y} = {x - y}");
            EventoCalculadora();
            }
            
        }



         public static void Multiplicação(int x, int y)
        {   
            if(EventoCalculadora != null)
            {
             System.Console.WriteLine("Chamando o método Multiplicação");
            System.Console.WriteLine($"{x} * {y} = {x * y}");
            EventoCalculadora();
            }
           
        }

         public static void Divisao(int x, int y)
        {   
            if(EventoCalculadora != null)
            {
            System.Console.WriteLine("Chamando o método Divisão");
            System.Console.WriteLine($"{x} / {y} = {x / y}");
            EventoCalculadora();
            }
            
        }

        

    }
}