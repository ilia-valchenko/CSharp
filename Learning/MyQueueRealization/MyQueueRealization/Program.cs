using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueRealization
{
    class Program
    {
        static void Main(string[] args)
        {

            UseGenericQueue();

            Console.WriteLine("\nTap to continue...");
            Console.ReadKey(true);
        }

        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }

        static void UseGenericQueue()
        {
            Queue<Person> pQueue = new Queue<Person>();

            pQueue.Enqueue(new Person("Ilia", "Valchenko", 20));
            pQueue.Enqueue(new Person("Sergey", "Burbon", 22));
            pQueue.Enqueue(new Person("Anton", "Yakoychyk", 21));

            Console.WriteLine("Who the first in the queue: {0}", pQueue.Peek());

            for(int i = 0; i < 5; i++)
            {
                try
                {
                    GetCoffee(pQueue.Dequeue());
                } catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
