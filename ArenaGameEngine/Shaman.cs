using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Shaman : Hero
    {
        public Shaman() : base("Shaman")
        {
        }
        public Shaman(string name) : base(name)
        {
        }

        public int Heal { get; set; }

        public void HealHero(Hero hero, int health)
        {
            hero.Health += health;
            Console.WriteLine(hero.Name + " was healed.");

        }
        public override void TakeDamage(int incomingDamage)
        {
            int dice = Random.Shared.Next(0, 20);
            if (dice <= 10)
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            int dice = Random.Shared.Next(0, 10);
            if (dice <= 5)
            {
                baseAttack = Strength * 2;
            }
            return baseAttack;
        }
    }
}
