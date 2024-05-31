using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public abstract class Hero : IHero
    {
        public string Name { get; private set; }
        public int Health { get; set; }
        public int BaseAttack { get; protected set; }
        public IWeapon Weapon { get; set; }

        public Hero(string name)
        {
            Name = name;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} атакува с {Weapon.Name} за {BaseAttack + Weapon.Attack} щети.");
        }

        public void EquipWeapon(IWeapon weapon)
        {
            Weapon = weapon;
            Console.WriteLine($"{Name} е въоръжен с {weapon.Name}.");
        }

        public abstract void SpecialAbility();
    }
}
