using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign04
{
    class BattlePlanContext
    {
        RedvsRed rvr;
        RedvsBlue rvb;
        RedvsGreen rvg;
        BluevsRed bvr;
        BluevsBlue bvb;
        BluevsGreen bvg;
        GreenvsRed gvr;
        GreenvsBlue gvb;
        GreenvsGreen gvg;
        ArrayList BattlePlans = new ArrayList();

        BattlePlanContext()
        {


            BattlePlans.Add(rvr);
            BattlePlans.Add(rvb);
            BattlePlans.Add(rvg);
            BattlePlans.Add(bvr);
            BattlePlans.Add(bvb);
            BattlePlans.Add(bvg);
            BattlePlans.Add(gvr);
            BattlePlans.Add(gvb);
            BattlePlans.Add(gvg);

        }

        decimal ComputeDamage(Dragon good, Dragon bad)
        {
            if (rvr.MatchesPlan(good, bad))
            {
                return rvr.ComputeDamage(good, bad);
            }
            else if (rvb.MatchesPlan(good, bad))
            {
                return rvb.ComputeDamage(good, bad);
            }
            else if (rvg.MatchesPlan(good, bad))
            {
                return rvg.ComputeDamage(good, bad);
            }
            else if (bvr.MatchesPlan(good, bad))
            {
                return bvr.ComputeDamage(good, bad);
            }
            else if (bvb.MatchesPlan(good, bad))
            {
                return bvb.ComputeDamage(good, bad);
            }
            else if (bvg.MatchesPlan(good, bad))
            {
                return bvg.ComputeDamage(good, bad);
            }
            else if (gvr.MatchesPlan(good, bad))
            {
                return gvr.ComputeDamage(good, bad);
            }
            else if (gvb.MatchesPlan(good, bad))
            {
                return gvb.ComputeDamage(good, bad);
            }
            else if (gvg.MatchesPlan(good, bad))
            {
                return gvg.ComputeDamage(good, bad);
            }
            else
            {
                Console.WriteLine("There are no matching battle plans.");
                return 0;
            }

        }
    }
}
