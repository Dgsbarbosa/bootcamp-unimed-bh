using System;
using projeto.src.Entities;

namespace Projeto
{
    class Program
    {
        
        static void Main(string[] args)
        {   // chamando metodos
            CriaPersonagem();
        
            //criando o personagem
            static void CriaPersonagem()
            {   
                System.Console.WriteLine("Criando os personagens");

                Personagem hero = new Personagem("Arus", 23, "Guerreiro");
                Magos hero2 = new Magos("Chubaca", 30, "Alien");
                
                

                System.Console.WriteLine();
                
            }

            
            /*
             //
            static void ()
            { 


            System.Console.WriteLine("");
            }

            */
        }
    }
}
