using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("MergeSort");
            Console.ResetColor();

            int[] arr = {9,9,9595,95,9,1,0,01,0,23,5,2,0,1,5};

            Console.Write("\nOriginal array: ");
            foreach (int item in arr)
                Console.Write(item + " ");

            MergeSort(ref arr, 0, arr.Length - 1);

            Console.Write("\n\nResulting array: ");
            foreach (int item in arr)
                Console.Write(item + " ");

            Console.WriteLine("\n\nTap to continue...");
            Console.ReadKey(true);
        }

        static void MergeSort(ref int[] arr, int left, int right)
        {
            if(left < right) // array consist of more than one element
            {
                int middle = (left + right) / 2;

                MergeSort(ref arr, left, middle);
                MergeSort(ref arr, middle + 1, right);
                Merge(ref arr, left, middle + 1, right);
            }
        }

        static void Merge(ref int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[arr.Length];
            int left_end = mid - 1;
            int tmp_pos = left;
            int numbers = right - left + 1;

            while((left <= left_end) && (mid <= right))
            {
                if (arr[left] <= arr[mid])
                    temp[tmp_pos++] = arr[left++];
                else
                    temp[tmp_pos++] = arr[mid++];
            }

            while(left <= left_end)
                temp[tmp_pos++] = arr[left++];

            while (mid <= right)
                temp[tmp_pos++] = arr[mid++];

            for (int i = 0; i < numbers; i++)
            {
                arr[right] = temp[right];
                right--;
            }
        }
    }
}
