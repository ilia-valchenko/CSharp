using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {9,8,7,5,5,4,3,1,2,10};
            int size = arr.Length;

            Sort(ref arr, ref size);

            Console.Write("Result array: ");
            foreach (int item in arr)
                Console.Write(item + " ");

            Console.WriteLine("\n\nTap to continue...");
            Console.ReadKey(true);
        }

        static void Sort(ref int[] arr, ref int size)
        {
            int i = 0, j = size - 1, p = arr[size / 2];

            do
            {
                while (arr[i] < p)
                    i++;

                while (arr[j] > p)
                    j--;

                if (i <= j)
                {
                    // swap
                    int helper = arr[i];
                    arr[i] = arr[j];
                    arr[j] = helper;

                    i++;
                    j--;
                }
            } while (i <= j);

            if (j > 0)
                Sort(ref arr, ref j);

            if (i < size)
            {
                int n = size - i;
                Sort(ref arr, ref n);
            }
                

        }
    }
}
