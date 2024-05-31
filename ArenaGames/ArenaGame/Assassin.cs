using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Assassin : Hero
    {
        public Assassin(string name) : base(name)
        {
            Health = 100;
            BaseAttack = 20;
        }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} използва способността си за скрито нападение!");
        }
    }

}
