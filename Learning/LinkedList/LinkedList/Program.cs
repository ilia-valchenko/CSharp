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

            list.Next();
            list.Next();
            list.Next();
            list.Add(888);

            list.AddToTail(13);
            list.AddToTail(14);

            // fix it
            // list.Next();
            // list.Next();
            // list.Delete();

            

            // print list
            Node<int> elem = list.GetHead();

            Console.WriteLine("HEAD: " + list.GetHead().value + "\n");
            Console.WriteLine("TAIL: " + list.GetTail().value + "\n");
            Console.WriteLine("CURRENT NODE: " + list.GetCurrentNode().value + "\n");

            Console.Write("LIST:");

            while (true)
            {
                Console.Write("  " + elem.value);
                if(elem.next == 9999)
                    break;
                else
                    elem = list.elems[elem.next];

            }

            Console.WriteLine("\n\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
