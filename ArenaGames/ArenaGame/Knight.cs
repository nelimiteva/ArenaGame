using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Knight : Hero
    {
        public Knight(string name) : base(name)
        {
            Health = 150;
            BaseAttack = 15;
        }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} използва способността си за блокиране!");
        }
    }

}
