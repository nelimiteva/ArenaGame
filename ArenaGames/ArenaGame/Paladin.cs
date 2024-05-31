using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Paladin : Hero
    {
        public Paladin(string name) : base(name)
        {
            Health = 120;
            BaseAttack = 10;
        }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} се лекува!");
        }
    }

}
