/*
 * Created by SharpDevelop.
 * User: IliA
 * Date: 12.02.2015
 * Time: 21:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpMethods
{
	class Program
	{
		public static void Main(string[] args)
		{		
			// TODO: Implement Functionality Here
			
			int aint = 2;
			int bint = 5;
			
			Console.WriteLine("Multiply product: " + multiply(aint,bint));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int multiply(int a, int b)
		{
			return a*b;
		}
	}
}