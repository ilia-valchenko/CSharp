/*
 * Created by SharpDevelop.
 * User: IliA
 * Date: 12.02.2015
 * Time: 19:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpString
{
	class Program
	{
		public static void Main(string[] args)
		{
			string empptyString = String.Empty;
			string anotherString = "";
			
			Console.WriteLine(empptyString.Equals(anotherString));
			Console.WriteLine(empptyString == anotherString); // maybe refere
			
			//String myDynamicString = new String("new string");
			
			//Summing
			string my = "My ";
			string name = "name is ";
			string ilia = "Ilia.";
			string result = my + name + ilia + " hello";
			
			result += " world!";
			
			System.Console.WriteLine(result);
			
			//String formatting 
			int x = 2;
			int y = 3;
			int sum = x + y;
			
			string resultString = String.Format("{0} + {1} = {2}", x, y, sum);
			Console.WriteLine("String formatting: " + resultString);
			
			//Substring 
			string fullString = "This_is_the_full_string.";
			string partOfString = fullString.Substring(5);
			Console.WriteLine(partOfString);
			string partOfStringTwo = fullString.Substring(5,12);
			Console.WriteLine(partOfStringTwo);
			
			//difference
			Console.WriteLine("Difference between (3,6) and (6,3)");
			string partOfStringThree = fullString.Substring(3,6);
			string partOfStringFour = fullString.Substring(6,3);
			Console.WriteLine(partOfStringThree);
			Console.WriteLine(partOfStringFour);
			
			//Replace method
			string myName = "Alina Orlova";
			string newName = myName.Replace("Orlova","Orlovskaya");
			Console.WriteLine("Real name is: " + newName);
			
			//Testing IndexOf
			string fruits = "orange, apple, banana";
			Console.WriteLine("Found orange on position: " + fruits.IndexOf("orange"));
			Console.WriteLine("Pineapple: " + fruits.IndexOf("pineapple"));
			Console.WriteLine("Meat: " + fruits.IndexOf("Meat"));
			Console.WriteLine("apple: " + fruits.IndexOf("apple"));
			Console.WriteLine("banana: " + fruits.IndexOf("banana"));
			
			//Exercise
			string nameIlia = "Ilia";
			string surname = "Valchenko";
			string age = "19";
			String myResultString = String.Format("{0} {1} age is {2}.",nameIlia,surname,age);
			Console.WriteLine(myResultString);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}