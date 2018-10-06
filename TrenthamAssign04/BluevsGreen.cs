using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign04
{
    class BluevsGreen : IBattlePlan
    {
        public decimal ComputeDamage(Dragon good, Dragon Bad)
        {
            return good.GetSize() * 5;
        }

        public bool MatchesPlan(Dragon good, Dragon Bad)
        {
            if (good.Type == "Blue" && Bad.Type == "Green")
            {
                return true;
            }
            else
                return false;
        
        }
    }
}
