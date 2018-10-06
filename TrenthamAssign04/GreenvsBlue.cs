using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign04
{
    class GreenvsBlue : IBattlePlan
    {
        public decimal ComputeDamage(Dragon good, Dragon Bad)
        {
            return good.GetSize() * 20;
        }

        public bool MatchesPlan(Dragon good, Dragon Bad)
        {
            if (good.Type == "Green" && Bad.Type == "Blue")
            {
                return true;
            }
            else
                return false;
        }
    }
}
