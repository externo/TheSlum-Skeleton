using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum
{
    class Pill: Bonus
    {
        internal Pill(string id="pill", int healthEffect = 200, int defenseEffect=0, int attackEffect = 100)
            : base(id, healthEffect, defenseEffect, attackEffect) 
        {
            this.Countdown = 1;
        }
    }
}
