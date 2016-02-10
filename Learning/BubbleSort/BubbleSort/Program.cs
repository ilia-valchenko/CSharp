using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10,18,3,0,0,5,120,3,5,4,3,2,100 };

            for(int i = 0; i < arr.Length; i++)
                for(int j = arr.Length - 1; j > i; j--)
                {
                    if(arr[j] < arr[j - 1])
                    {
                        int helper = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = helper; 
                    }
                }

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
