using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign04
{
    class BluevsBlue : IBattlePlan
    {
        public decimal ComputeDamage(Dragon good, Dragon Bad)
        {
            return good.GetSize() * 10;
        }

        public bool MatchesPlan(Dragon good, Dragon Bad)
        {
            if (good.Type == "Blue" && Bad.Type == "Blue")
            {
                return true;
            }
            else
                return false;
        }
    }
    
}
