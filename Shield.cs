using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum
{
    class Shield: Item
    {
        //HealthEffect of 0, DefenseEffect of 50 and AttackEffect of 0.
        internal Shield(string id = "shield", int healthEffect = 0, int defenseEffect = 50, int attackEffect = 0)
            : base(id, healthEffect, defenseEffect, attackEffect) { }
    }
}
