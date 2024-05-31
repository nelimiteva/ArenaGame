using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Dagger : IWeapon
    {
        public string Name => "Кама";
        public int Attack => 5;
        public void SpecialAbility()
        {
            Console.WriteLine("Предизвиква кървене!");
        }
    }

}
