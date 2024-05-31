using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
            Health = 80;
            BaseAttack = 15;
        }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} прави заклинание!");
        }
    }

}
