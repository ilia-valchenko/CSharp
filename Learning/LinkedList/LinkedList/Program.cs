using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CUSTOM DOUBLELINKED LIST\n");
            Console.ResetColor();

            LinkedList<int> list = new LinkedList<int>();

            list.AddToHead(3);
            list.AddToHead(4);
            list.AddToHead(5);
            list.AddToHead(6);

            list.AddToTail(11);
            list.AddToTail(12);
            list.AddToTail(13);
            list.AddToTail(14);

            foreach(Node<int> item in list.GetList())
            {
                if(item != null)
                {
                    Console.Write(list.GetList()[item.next].value + "  ");
                }
            }

            Console.WriteLine("\n\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
