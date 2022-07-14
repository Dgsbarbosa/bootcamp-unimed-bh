using System;
using System.Collections.Generic;


namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> estados = new List<string>();
            estados.Add("SP");
            estados.Add("MG");
            estados.Add("BA");
            estados.Add("CE");
            
            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}\n");

            //lISTANDO OS ESTADOS
            foreach (var item in estados)
            {
                System.Console.WriteLine(item,"\n");
            }

            for (int i = 0; i < estados.Count; i++)
            {
                System.Console.WriteLine($"Indice: {i}, Valor: {estados[i]}\n");
            }



            //Trabalhando com Arrrays

            int[] arrayInteiro = new int[4];

            arrayInteiro[0] = 10;
            arrayInteiro[1] = 20; 
            arrayInteiro[2] = 30;
            arrayInteiro[3] = 40;

            Console.WriteLine("Percorrendo o array com For");

            for (int i = 0; i < arrayInteiro.Length; i++)
            {
                Console.WriteLine(arrayInteiro[i]);
            } 

        }
    }
}
