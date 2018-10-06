using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign04
{
    class EmeraldDragon : Dragon
    {
        public EmeraldDragon(string name, decimal size, bool good) : base(name, "Green", size, good)
        {
            Dragon dragon = new Dragon(name, "Green", size, good);
        }

        public override string ToString()
        {
            if (Good)
            {
                return $"{Name} - {Type} - {Size} - Good";
            }
            else
                return $"{Name} - {Type} - {Size} - Evil";
        }
    }
}
