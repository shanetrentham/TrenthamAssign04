using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon Good = new Dragon("", "", 0, true);
            Dragon Evil = new Dragon("", "", 0, true);
            DragonBuilder builder = new DragonBuilder();

            Console.WriteLine("Enter the Good dragon: ");
            builder.BuildDragon();
            Good = builder.GetDragon();

            Console.WriteLine("Enter the Evil dragon: ");
            builder.BuildDragon();
            Evil = builder.GetDragon();
        }
    }
}
