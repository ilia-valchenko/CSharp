using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("This is my custom stack realization.");
            Console.ResetColor();

            bool isStop = false;
            Stack<int> stackTest = new Stack<int>();

            while (!isStop)
            {
                Console.WriteLine("\n\nThanks! Now you have to choose one of the proposed operations:\nPush: 1\nPop: 2\nPeek: 3\nPrint stack: 4\nStop: 5\n");
                int operation = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case (1):
                        Console.Write("\nEnter the element to push: ");
                        stackTest.Push(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case (2):
                        stackTest.Pop();
                        break;

                    case (3):
                        Console.Write("\nTop of stack is: " + stackTest.Peek());
                        break;

                    case (4):
                        Console.WriteLine("\nStack's elements:");

                        foreach(int item in stackTest.GetArrayOfStackElements())
                            Console.WriteLine(item);

                        break;

                    case (5):
                        isStop = true;
                        break;
                }
            }

            Console.WriteLine("\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
