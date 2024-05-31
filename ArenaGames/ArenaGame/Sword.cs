using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Sword : IWeapon
    {
        public string Name => "Меч";
        public int Attack => 10;
        public void SpecialAbility() { }
    }

}
