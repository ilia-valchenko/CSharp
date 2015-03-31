/*
 * Created by SharpDevelop.
 * User: IliA
 * Date: 28.02.2015
 * Time: 20:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Overload
{
	class Cat // private default
	{
		public int Age{get;set;}
		public string Color{get;set;}
	}
	
	class Complex
	{
		public int Re{get;set;}
		public int Im{get;set;}
		
		public Complex(int re, int im)
		{
			Re = re;
			Im = im;
		}
		
		public static Complex operator ~ (Complex Z)
		{
			return new Complex(Z.Re,-Z.Im);
		}
		
		public static Complex operator + (Complex A, Complex B)
		{
			return new Complex(A.Re+B.Re, A.Im+B.Im);
		}
		
		public void PrintComplexNumber() // non-static
		{
			Console.WriteLine(Re + "+" + Im + "i");
		}
	}
	
	class Start
	{
		public static void Main(string[] args)
		//public static void Main()
		{
			Cat myCat = new Cat{Age = 1, Color = "Black"}; // initializators
			Cat mySecondCat = new Cat{Age = 2, Color = "White"};
			
			Console.WriteLine("My first cat info:\nAge: " + myCat.Age + "\nColor: " + myCat.Color);
			Console.WriteLine("\nMy second cat info:\nAge: " + mySecondCat.Age + "\nColor: " + mySecondCat.Color);
			
			Console.WriteLine("OVERLOAD OPERATION TESTING:");
			Complex z = new Complex(1,2);
			z.PrintComplexNumber();
			(~z).PrintComplexNumber(); // overload operator ~
			Complex c = new Complex(2,3);
			Complex res = z+c;
			Console.WriteLine("The result summing of two complex number:\n");
			z.PrintComplexNumber();
			c.PrintComplexNumber();
			Console.WriteLine("RESULT: ");
			res.PrintComplexNumber();
			
			Console.WriteLine("\nTap to continue...");
			Console.ReadKey(true);
		}
	}
}