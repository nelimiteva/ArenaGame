using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Bow : IWeapon
    {
        public string Name => "Лък";
        public int Attack => 7;
        public void SpecialAbility()
        {
            Console.WriteLine("Изстрелва множество стрели!");
        }
    }

}
