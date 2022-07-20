using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace projeto.src.Entities
{
    public class Magos : Personagem
    {
        public Magos(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack()
        {
            return this.Name + "Ataque de poder";
        }
    }
}