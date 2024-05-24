using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Paladin : Hero
    {
        public bool HasShield { get; set; }
        public Paladin() : base("Paladin")
        {
        }
        public Paladin(string name) : base(name)
        {
        }
        public override void TakeDamage(int incomingDamage)
        {
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 32 || HasShield)
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 5)
            {
                baseAttack = Strength * 4;
            }
            return baseAttack;
        }
    }
}
