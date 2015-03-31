/*
 * Created by SharpDevelop.
 * User: IliA
 * Date: 12.02.2015
 * Time: 6:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;
using System.Collections.Generic;

namespace CSharpTestLanguage
{
	class Program
	{
		public enum CarType 
		{
			Toyota = 1,
			Honda = 2,
			Ford = 3,		
			
		}
		
		public static void Main(string[] args)
		{
			var myInt = 1;
			var myBoolean = true;
			var myString = "My name is Ilia.";
			//array
			int[] myArray = {1,2,3,4,5,6,7,8,9,10};
			int[,] matrixArray = new int[2,2];
			
			matrixArray[0,0] = 1;
			matrixArray[0,1] = 2;
			matrixArray[1,0] = 3;
			matrixArray[1,1] = 4;
			
			int[,] predefinedArray = new int[2,2] { {1,2}, {3,4} };
			
			//tutorial task
			string[] fruits = {"orange", "banan", "pineapple"};
			
			Console.Write("All my fruits: ");
			
			foreach(string fruit in fruits) {
				Console.Write(fruit + " ");
			}
			
			CarType myCar = CarType.Toyota;
			
			Console.WriteLine("\nHello World!");
			Console.WriteLine("myInt: " + myInt + " myBoolen: " + myBoolean + " myString: " + myString);
			Console.WriteLine("My car is: " + myCar);
			Console.WriteLine("Testing output of my array.");
			
			foreach(int i in myArray) 
			{
				Console.Write(i + " ");
			}
			
			//List 
			List<short> numbers = new List<short>();
			
			//Console.WriteLine("List called numbers: " + numbers);
			
			numbers.Add(1);
			numbers.Add(2);
			numbers.Add(3);
			
			List<string> fruitsString = new List<string>();
			fruitsString.Add("apple");
			fruitsString.Add("banana");
			fruitsString.Add("orange");
			
			//range
			Console.WriteLine("Range of List of fruits: " + fruitsString.Count);
			
			//delete
			fruitsString.Remove("banana");
			Console.WriteLine("Range of list without banana: " + fruitsString.Count);
			
			fruitsString.RemoveAt(0);
			Console.WriteLine("Using RemoveAt: " + fruitsString.Count);
			
			//Testing AddRange
			List<string> food = new List<string>();
			food.Add("meat");
			food.Add("banana");
			
			List<string> vegetables = new List<string>();
			vegetables.Add("tomato");
			vegetables.Add("carrot");
			
			Console.WriteLine("List food + vegetables: ");
				
			food.AddRange(vegetables);
			foreach(string entity in food)
			{
				Console.Write(entity + " ");
			}
			
			//Testing AddRange with different types
			List<int> ListInt = new List<int>();
			ListInt.Add(100);
			ListInt.Add(200);
			ListInt.Add(300);
			
			//food.AddRange(ListInt); // impossible?
			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}