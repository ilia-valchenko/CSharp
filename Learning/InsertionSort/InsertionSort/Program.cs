using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5,12,1,1,0,56,98,1,23,6,4,7,8,10,100};

            for(int i = 1; i < arr.Length; i++)
                for(int j = i; j > 0 && arr[j-1] > arr[j]; j--)
                {
                    int helper = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = helper;
                }

            Console.WriteLine("Print result:");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
                    

            Console.WriteLine("\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
