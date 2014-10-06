using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Bonus
{
    class Injection: Bonus, ITimeoutable
    {
        internal Injection(string id="injection", int healthEffect = 200, int defenseEffect = 0, int attackEffect = 0)
            : base(id, healthEffect, defenseEffect, attackEffect) 
        {
            this.Countdown = 3;
        }
    }
}
