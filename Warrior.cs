using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Warrior: Character, IAttack
    {
        public Warrior(string id, int x, int y, Team team, int healthPoints=0, int defensePoints=0, int range=0)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = 0;
        }

        public int AttackPoints { get; set; }
        protected override void ApplyItemEffects(Item item)
        {
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.HealthPoints -= item.HealthEffect;
            this.DefensePoints -= item.DefenseEffect;
            this.AttackPoints -= item.AttackEffect;
            if (this.HealthPoints < 0)
            {
                this.HealthPoints = 1;
            }
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
        }
        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
        }
        public override Character GetTarget(IEnumerable<Character> targetsList);
        {
            return targetsList.First();
        }
    }
}
