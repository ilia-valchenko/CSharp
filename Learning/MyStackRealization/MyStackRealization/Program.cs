using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackRealization
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStackInt = new Stack<int>();

            for (int i = 0; i < 20; i++)
            {
                myStackInt.Push(i);
                Console.Write(myStackInt.Peek() + " ");
                if (i % 5 == 0)
                    Console.WriteLine("\nSize of array: " + myStackInt.SizeOfArray + "\n");
            }

            Console.WriteLine("Peek of stack: " + myStackInt.Peek());

            Console.WriteLine("\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
