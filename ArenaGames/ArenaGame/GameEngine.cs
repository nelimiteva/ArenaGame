using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class GameEngine
    {
        private List<Hero> heroes = new List<Hero>();
        private List<IWeapon> weapons = new List<IWeapon>();

        public GameEngine()
        {
          
            weapons.Add(new Sword());
            weapons.Add(new Dagger());
            weapons.Add(new Bow());

         
            heroes.Add(new Mage("Gandalf"));
            heroes.Add(new Paladin("Arthur"));
            heroes.Add(new Assassin("Archer"));
            heroes.Add(new Knight("Rodrik"));
        }

        public void StartBattle()
        {
            foreach (var hero in heroes)
            {
                var weapon = weapons[new Random().Next(weapons.Count)];
                hero.EquipWeapon(weapon);
                hero.Attack();
                hero.SpecialAbility();
                weapon.SpecialAbility();
            }
        }
    }

}
