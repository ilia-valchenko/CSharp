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
            int[] arr = { 1, 6, 6, 9, 8, 52, 56, 55, 0, 0, 1 };

            Console.Write("Original array: ");
            foreach (int item in arr)
                Console.Write(item + " ");

            Sort(ref arr, 0, arr.Length - 1);

            Console.Write("\n\nQuickSort result: ");
            foreach (int item in arr)
                Console.Write(item + " ");

            Console.WriteLine("\n\nTap to continue...");
            Console.ReadKey(true);
        }

        static void Sort(ref int[] arr, int left, int right)
        {
            int i = left, j = right, p = arr[(i + j) / 2];

            while(i <= j)
            {
                while (arr[i] < p)
                    i++;

                while (arr[j] > p)
                    j--;

                if(i <= j)
                {
                    int helper = arr[i];
                    arr[i] = arr[j];
                    arr[j] = helper;

                    i++;
                    j--;
                }
            }

            if (j > left)
                Sort(ref arr, left, j);

            if (i < right)
                Sort(ref arr, i, right);
        }
    }
}
