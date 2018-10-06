using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign04
{
    class DragonBuilder
    {
        Dragon dragon;
        SapphireDragon BlueDragon = new SapphireDragon("", 0, true);
        RubyDragon RedDragon = new RubyDragon("", 0, true);
        EmeraldDragon GreenDragon = new EmeraldDragon("", 0, true);
        string name;
        string type;
        decimal size;
        Boolean good;

        public DragonBuilder()
        {
            dragon = null;
        }

        public void BuildDragon()
        {
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            if (name.Length < 1)
            {
                Console.WriteLine("Name must not be empty!");
                Console.WriteLine("Name: ");
                name = Console.ReadLine();

            }

            Console.WriteLine("Type: ");
            type = Console.ReadLine();

            Console.WriteLine("Size: ");
            size = Convert.ToDecimal(Console.ReadLine());
            if (size < 0)
            {
                Console.WriteLine("Size must not be a negative number.");
                Console.WriteLine("Size: ");
                size = Convert.ToDecimal(Console.ReadLine());

            }

            Console.WriteLine("Good or Evil: ");
            string UserIn = Console.ReadLine();

            if (UserIn == "Good" || UserIn == "good")
            {
                good = true;
            }
            else if (UserIn == "Evil" || UserIn == "evil")
            {
                good = false;
            }
            else
            {
                Console.WriteLine("Must be either Good or Evil!");

            }

            if (type == "Green" || type == "green")
            {
                GreenDragon.SetName(name);
                GreenDragon.SetType("Green");
                GreenDragon.SetSize(size);
                GreenDragon.SetGood(good);
            }

            else if (type == "Blue" || type == "blue")
            {
                BlueDragon.SetName(name);
                BlueDragon.SetType("Blue");
                BlueDragon.SetSize(size);
                BlueDragon.SetGood(good);
            }

            else if (type == "Red" || type == "red")
            {
                RedDragon.SetName(name);
                RedDragon.SetType("Red");
                RedDragon.SetSize(size);
                RedDragon.SetGood(good);
            }
        }

        public Dragon GetDragon()
        {
            if (type == "Green" || type == "green")
            {
                return GreenDragon;
            }
            else if (type == "Blue" || type == "blue")
            {
                return BlueDragon;
            }
            else if (type == "Red" || type == "red")
            {
                return RedDragon;
            }
            else
                return null;
        }
    }
}
