using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal interface IHero
    {

            string Name { get; }
            int Health { get; set; }
            int BaseAttack { get; }
            IWeapon Weapon { get; set; }

            void Attack();
            void EquipWeapon(IWeapon weapon);
            void SpecialAbility();


    }
}
