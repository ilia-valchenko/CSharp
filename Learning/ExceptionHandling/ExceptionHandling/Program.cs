using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Simple Exeption Example ********");

            Car mitsubishi = new Car("Mitsubishi Evolution 10", 40);

            mitsubishi.CrankTunes(true);

            try
            {
                for (int i = 0; i < 10; i++)
                    mitsubishi.Accelerate(15);
            } catch(Exception e)
            {
                Console.WriteLine("\n **** Error! ****");
                Console.WriteLine("Member name: {0}", e.TargetSite);
                Console.WriteLine("Class definition member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
            }

            Console.WriteLine("\nWork after catch block.");
            
            Console.WriteLine("\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
