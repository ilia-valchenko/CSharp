/*
 * Created by SharpDevelop.
 * User: IliA
 * Date: 12.02.2015
 * Time: 21:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpWhileLoop
{
	class Program
	{
		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			
			int x = 10;
			while(x != 0)
			{
				if(x == 5)
					continue; //break;
				
				Console.WriteLine("Now X is: " + x);
				x--;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}