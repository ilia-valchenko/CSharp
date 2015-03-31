/*
 * Created by SharpDevelop.
 * User: IliA
 * Date: 27.02.2015
 * Time: 6:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpProperties
{
	class PropAccess
	{
		public int prop; // default private
		
		public int MyProp
		{
			get
			{
				return prop;
			}
			private set
			{
				prop = value;
			}
		}
	}
	
		class WithoutSet
	{
		private string str = "This is private string.";
		
		public string Str
		{
			get 
			{
				return str;
			}
		}
	}
	
	class Heir:PropAccess
	{
		public static void Printer(int value1, double value2, bool value3)
		{
			Console.WriteLine("Printer function:\n" + value1 + "\n" + value2 + "\n" + value3);
		}
		
		public static void Main(string[] args)
		{
			int value = 10;
			Heir ob = new Heir();
			
			//ob.MyProp=value; // private set
			ob.prop=value;
			Console.WriteLine("Value of field 'prop' instance Heir class = " + ob.MyProp);
			
			PropAccess ob2 = new PropAccess();
			//ob2.MyProp = 300; // private set
			Console.WriteLine("PropAccess ob2 = " + ob2.MyProp); // get
			
			int i = 123;
			object box = i;
			
			if(box is int) 
				Console.WriteLine("Box contains an Int.");
			else
				Console.WriteLine("Box contains NOT an Int.");
			
			int x = 1200000000;
			short y = 3;
			//y = checked((short)x); // System.OverFlowException
			//Console.WriteLine("Explicit conversion Int into Short: " + y); 
			
			int x1 = 100000000;
			int x2 = 200000000;
			//int res = checked(x1*x2); // runtime error
			//Console.WriteLine("Production result is " + res);
			
			//int fin = checked(100000000*200000000); //compilation error
			
			Printer(750, 2.2, true);
			//Printer(100, 1.0, value2:"It's me!");
			
			WithoutSet newOb = new WithoutSet();
			//newOb.Str = "New value of string."; // access only for read
			Console.WriteLine("Value of newOb is: " + newOb.Str);
			
			Console.WriteLine("Tap to continue...");
			Console.ReadKey(true);
		}
		
	}
}