using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Creation monster = new Creation(TypeOfEnvironment.ocean, TypeOfFood.carnivorous, TypeOfLimbs.foot);
            //monster.PrintInfo();

            Human bart = new Human("Bart", 10, Sex.male);
            bart.PrintInfo();

            Console.WriteLine("\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
