using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign04
{
    interface IBattlePlan
    {
        Boolean MatchesPlan(Dragon good, Dragon Bad);
        decimal ComputeDamage(Dragon good, Dragon Bad);
    }
}
