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
            Console.Write("This is my custom stack realization based on integer values.\nPlease enter the size of stack: ");

            bool isStop = false;
            int size = Convert.ToInt32(Console.ReadLine());
            Stack stackTest = new Stack(size);

            while (!isStop)
            {
                Console.WriteLine("\n\nThanks! Now you have to choose one of the proposed operations:\nPush: 1\nPop: 2\nPeek: 3\nStop: 4\n");
                int operation = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case (1):
                        Console.Write("Enter the element to push: ");
                        stackTest.Push(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case (2):
                        stackTest.Pop();
                        Console.WriteLine("Pop() successfully completed!");
                        break;

                    case (3):
                        Console.Write("Top of stack is: " + stackTest.Peek());
                        break;

                    case (4):
                        isStop = true;
                        break;
                }
            }
            
            Console.ReadKey(true);
        }
    }
}
