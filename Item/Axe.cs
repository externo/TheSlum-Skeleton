using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Item
{
    class Axe: Item
    {
        //HealthEffect of 0, DefenseEffect of 0 and AttackEffect of 75.
        internal Axe(string id = "axe", int healthEffect = 0, int defenseEffect = 0, int attackEffect = 75)
            : base(id, healthEffect, defenseEffect, attackEffect) { }
    }
}
