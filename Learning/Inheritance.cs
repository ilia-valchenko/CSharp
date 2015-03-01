/*
 * Created by SharpDevelop.
 * User: IliA
 * Date: 01.03.2015
 * Time: 10:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Inheritance
{
	class A
	{
		public int i = 0;
		
		/*public A(int h)
		{
			i = h;
		}*/
		
		public void Show()
		{
			Console.WriteLine("Base class: " + i);
		}
	}
	
	class B:A
	{
		new int i; // hides a i member of the class A
		
		public B(int b)
		{
			i = b;
		}
		
		public void Show()
		{
			Console.WriteLine("Inherit class: " + i);
		}
	}
	
	/*class Start
	{
		public static void Main() // without arguments
		{
			B ob = new B(300);
			ob.Show();
			
			Console.WriteLine("Tap to continue...");
			Console.ReadKey(true);
		}
	}*/
	
	class NameHiding
	{
		static void Main()
		{
			B ob1 = new B(3);
			ob1.Show();
			
			A ob2 = new A();
			ob2.Show();
			
			A ob3 = new B(9);
			ob3.Show();
			
			Console.WriteLine("Tap to continue...");
			Console.ReadKey(true);
		}
	}
}