using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackString
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stackString = new Stack();

            for (int i = 0; i < 20; i++)
                stackString.Push(Convert.ToString(i));

            string[] arr = stackString.GetArrayOfStackElements();

            foreach (string item in arr)
                Console.Write(item + " ");

            Console.WriteLine("\n\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
