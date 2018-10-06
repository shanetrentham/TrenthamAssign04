using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign04
{
    class RedvsRed : IBattlePlan
    {
       public bool MatchesPlan(Dragon good, Dragon bad)
        {
            if (good.Type == "Red" && bad.Type == "Red")
            {
                return true;
            }
            else
                return false;
        }
        // Normal damage dealt is 10 dps.
        public decimal ComputeDamage(Dragon good, Dragon bad)
        {
            return good.GetSize() * 10;
        }
    }
}
