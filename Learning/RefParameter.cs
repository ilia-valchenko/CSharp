/*
 * Created by SharpDevelop.
 * User: IliA
 * Date: 17.02.2015
 * Time: 23:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RefParameter
{
	class Program
	{
		public static void Main(string[] args)
		{	
			// TODO: Implement Functionality Here
			int a=2,b=3;
			
			Console.WriteLine(Multiplication(ref a, ref b));
			PrintList(new int[]{2,4,6,8,10});
			
			Console.WriteLine("\nTest Multiplication method with named arguments: " + Multiplication_2(first:20, second:5));
			//Console.WriteLine("Test Multiplication_2: " + Multiplication_2(ref first:20, ref second:5)); // impossible
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int Multiplication(ref int first, ref int second)
			{
				int a=first, b=second;
				return a*b;
			}
		
		//static int Multiplication_2(ref int a, ref int b)
		static int Multiplication_2(int first, int second)
		{
			int a = first; // should be initialized
			int b = second;
			
			return a*b;
		}
		
		static void PrintList(params int[] List) // private default
        //void PrintList(params int[] List)
		{
			Console.WriteLine("Print out of our list of integers: ");
			foreach(int i in List)
			{
				Console.Write(i + " ");
			}
		}
	}
}