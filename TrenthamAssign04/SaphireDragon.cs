using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign04
{
    class SapphireDragon : Dragon
    {

        public SapphireDragon(string name, decimal size, bool good) : base(name, "Blue", size, good)
        {
            Dragon dragon = new Dragon(name, "Blue", size, good);
        }

        public static SapphireDragon CallConstructor(string name, string type, decimal size, bool good)
        {
            return new SapphireDragon(name, size, good);
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
