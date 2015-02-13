/*
 * Created by SharpDevelop.
 * User: IliA
 * Date: 12.02.2015
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Dictionaries
{
	class Program
	{
		public static void Main(string[] args)
		{
			Dictionary<string,long> phonebook = new Dictionary<string,long>();
			
			phonebook.Add("Jessica",1236547897);
			phonebook.Add("Mike",154795645545);
			phonebook.Add("Ilia",4789955666);
			
			// alternative method adding to dictionary
			phonebook["Ilia"] = 125748986;
			
			//Console.WriteLine("Tyler number is: " + phonebook["Tyler"]); //KeyNotFoundException
			
			if(phonebook.ContainsKey("Tyler"))
			{
				Console.WriteLine("Tyler number is: " + phonebook["Tyler"]);
			}
			
			if(phonebook.ContainsKey("Ilia"))
			{
				Console.WriteLine("Ilia number is: " + phonebook["Ilia"]);
			}
			
			phonebook.Remove("Jessica");
			Console.WriteLine("Dictionary size is: " + phonebook.Count);
			
			/*Console.WriteLine("Output my dictionary:");
				
			foreach(string name in phonebook)
			{
				Console.Write(name + " ");
			}*/
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}