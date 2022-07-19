using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construtores.models
{
    public class Calculadora
    {
        public static void Somar(int x, int y)
        {   
            System.Console.WriteLine("Chamando o método Soma");
            System.Console.WriteLine($"{x} + {y} = {x + y}\n ");
        }

         public static void Subtrair(int x, int y)
        {   
            System.Console.WriteLine("Chamando o método Subtração");
            System.Console.WriteLine($"{x} - {y} = {x - y}\n ");
        }



         public static void Multiplicação(int x, int y)
        {   
            System.Console.WriteLine("Chamando o método Multiplicação");
            System.Console.WriteLine($"{x} * {y} = {x * y}\n ");
        }

         public static void Divisao(int x, int y)
        {   
            System.Console.WriteLine("Chamando o método Divisão");
            System.Console.WriteLine($"{x} / {y} = {x / y}\n");
        }

        



        
    }
}