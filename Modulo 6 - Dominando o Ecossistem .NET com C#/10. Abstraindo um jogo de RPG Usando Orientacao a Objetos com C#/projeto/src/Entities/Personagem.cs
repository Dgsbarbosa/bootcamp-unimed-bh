using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.src.Entities
{
    public class Personagem
    {
        
        public string Name;
        public int Level;
        public string HeroType;

        
        


        public  Personagem(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            
            

            System.Console.WriteLine($"Personagem: {Name}\nLevel: {Level}\nTipo de Guerreiro: {HeroType}");
            System.Console.WriteLine();
            

        }

        public virtual string Attack()
        {
            return this.Name + "Atacou com sua espada";
        }

            


        }
       

    }
