using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 10; i++){    
                Console.WriteLine($"\nTabuada do {i}" );
            
                for(int j = 1; j<= 10; j++){
               
                Console.WriteLine($"{i} X {j} = {i * j}");   
            }}
                string texto;
            do{
                texto = Console.ReadLine();
                Console.WriteLine($"Você digitou {texto}");

            } while (!string.IsNullOrEmpty(texto));
            {
                Console.WriteLine("Este valor é nulo");
            }

            
        }
    }
}
