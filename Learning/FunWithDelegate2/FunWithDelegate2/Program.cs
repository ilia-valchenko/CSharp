using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithDelegate2
{
    public delegate int BinaryOp(int a, int b);

    class SimpleMath {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Subsctruct(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ Fun with delegates *************");

            BinaryOp bo = new BinaryOp(SimpleMath.Add);
            SimpleMath sm = new SimpleMath();

            Console.WriteLine("\nResult of using BinaryOp delegate: {0}", bo(12, 6));
            bo += SimpleMath.Multiply;

            Console.WriteLine("\nTest Multiply method: {0}", bo.Invoke(5,5));
            bo += SimpleMath.Add;

            for (int i = 0; i < 3; i++) 
            Console.WriteLine("Cycle result {0} loop: {1}", i, bo.Invoke(i, 2));

            bo += sm.Subsctruct;
            DisplayDelegateInfo(bo);
        

            Console.WriteLine("\nTap to continue...");
            Console.ReadKey(true);
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            Console.WriteLine("\nPrint delegate's list of methods.");
            foreach (Delegate d in delObj.GetInvocationList())
                Console.WriteLine("Method's name: {0}, Target: {1}", d.Method, d.Target);
        }
    }
}
