using System;

class Start
	{
		static void Main(string[] args)
		{	
			MainMenu();
		}
		
		public static void MainMenu()
		{
			Console.Clear();
			
			int command = 0;
			
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("\nWELCOME TO CREATION GENERATOR");
			Console.ResetColor();
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[1]");
			Console.ResetColor();
			Console.Write(" Create a new creature");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[2]");
			Console.ResetColor();
			Console.Write(" Create human");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[3]");
			Console.ResetColor();
			Console.Write(" Create dog");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[4]");
			Console.ResetColor();
			Console.Write(" Create bird");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[5]");
			Console.ResetColor();
			Console.Write(" Exit");
			
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("\n\nEnter a command: ");
			Console.ResetColor();
			try
			{
				command = Convert.ToInt32(Console.ReadLine());
			}
			catch(System.FormatException e)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("\nSYSTEM FORMAT EXCEPTION: ");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(e.StackTrace);
				Console.ResetColor();
				
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("\n\nTap to continue...");
				Console.ReadKey(true);
			}
			
			switch(command)
			{
				case 1:
					CreatureAction(true);
					break;
					
				case 2:
					HumanAction(true);
					break;
					
				case 3:
					DogAction(true);
					break;	
					
				case 4:
					BirdAction(true);
					break;
					
				case 5:
					break;
			}
		}
		
		public static void CreatureAction(bool visible)
		{
			Creature cr1 = new Creature();
			
			if(visible)
			{
				Console.Clear();
				cr1.PrintCreature();
			}
			
			int command = 0;
			
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("\nCREATION GENERATOR MENU");
			Console.ResetColor();
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[1]");
			Console.ResetColor();
			Console.Write(" Create hybrid");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[2]");
			Console.ResetColor();
			Console.Write(" Go back");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[3]");
			Console.ResetColor();
			Console.Write(" Exit");
			
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("\n\nEnter a command: ");
			Console.ResetColor();
			try
			{
				command = Convert.ToInt32(Console.ReadLine());
			}
			catch(System.FormatException e)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("\nSYSTEM FORMAT EXCEPTION: ");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(e.StackTrace);
				Console.ResetColor();
				
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("\n\nTap to continue...");
				Console.ReadKey(true);
			}
			
			switch(command)
			{
				case 1:
					Console.Clear();
					
					Creature cr2 = new Creature();
					
					cr1.PrintCreature();
					cr2.PrintCreature();
					
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("\nAFTER MUTATION:");
					Creature res = cr1 + cr2;
					res.PrintCreature();
					
					CreatureAction(false);
					break;
					
				case 2:
					Console.Clear();
					MainMenu();
					break;
					
				case 3:
					break;	
			}
		}
		
		public static void HumanAction(bool visible)
		{
			Human h1 = new Human();
			
			if(visible)
			{
				Console.Clear();
				h1.PrintCreature();
			}
			
			int command = 0;
			
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("\nCREATION GENERATOR MENU");
			Console.ResetColor();
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[1]");
			Console.ResetColor();
			Console.Write(" Human+human");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[2]");
			Console.ResetColor();
			Console.Write(" Human+bird");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[3]");
			Console.ResetColor();
			Console.Write(" Human+dog");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[4]");
			Console.ResetColor();
			Console.Write(" Implicit conversion to Bird");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[5]");
			Console.ResetColor();
			Console.Write(" Implicit conversion to Dog");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[6]");
			Console.ResetColor();
			Console.Write(" Go back");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[7]");
			Console.ResetColor();
			Console.Write(" Exit");
			
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("\n\nEnter a command: ");
			Console.ResetColor();
			try
			{
				command = Convert.ToInt32(Console.ReadLine());
			}
			catch(System.FormatException e)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("\nSYSTEM FORMAT EXCEPTION: ");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(e.StackTrace);
				Console.ResetColor();
				
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("\n\nTap to continue...");
				Console.ReadKey(true);
			}
			
			switch(command)
			{
				case 1:
					Console.Clear();
					
					Human h2 = new Human();
					h1.PrintCreature();
					h2.PrintCreature();
					
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("\nAFTER MUTATION:");
					Human res1 = h1 + h2;
					res1.PrintCreature();
					
					HumanAction(false);
					break;
					
				case 2:
					Console.Clear();
					
					Creature h3 = new Human();
					Creature b3 = new Bird();
					
					h3.PrintCreature();
					b3.PrintCreature();
					
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("\nAFTER MUTATION:");
					Creature res2 = h3 + b3;
					res2.PrintCreature();
					
					HumanAction(false);
					break;
					
				case 3:
					Console.Clear();
					
					Creature h4 = new Human();
					Creature d4 = new Dog();
					
					h4.PrintCreature();
					d4.PrintCreature();
					
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("\nAFTER MUTATION:");
					Creature res3 = h4 + d4;
					res3.PrintCreature();
					
					HumanAction(false);
					break;	
					
				case 4:
					Console.Clear();
					
					Human human = new Human();
					human.PrintCreature();
					
					Bird bird = human;
					bird.PrintCreature();
					
					HumanAction(false);
					break;
					
				case 5:
					Console.Clear();
					
					Human human1 = new Human();
					human1.PrintCreature();
					
					Bird dog = human1;
					dog.PrintCreature();
					
					HumanAction(false);
					break;
					
				case 6:
					Console.Clear();
					MainMenu();
					break;
					
				case 7:
					break;
			}
		}
		
		public static void DogAction(bool visible)
		{
			Dog d1 = new Dog();
			
			if(visible)
			{
				Console.Clear();
				d1.PrintCreature();
			}
			
			int command = 0;
			
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("\nCREATION GENERATOR MENU");
			Console.ResetColor();
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[1]");
			Console.ResetColor();
			Console.Write(" Dog+dog");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[2]");
			Console.ResetColor();
			Console.Write(" Dog+human");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[3]");
			Console.ResetColor();
			Console.Write(" Dog+bird");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[4]");
			Console.ResetColor();
			Console.Write(" Go back");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[5]");
			Console.ResetColor();
			Console.Write(" Exit");
			
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("\n\nEnter a command: ");
			Console.ResetColor();
			try
			{
				command = Convert.ToInt32(Console.ReadLine());
			}
			catch(System.FormatException e)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("\nSYSTEM FORMAT EXCEPTION: ");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(e.StackTrace);
				Console.ResetColor();
				
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("\n\nTap to continue...");
				Console.ReadKey(true);
			}
			
			switch(command)
			{
				case 1:
					Console.Clear();
					
					Dog d2 = new Dog();
					d1.PrintCreature();
					d2.PrintCreature();
					
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("\nAFTER MUTATION:");
					Dog res1 = d1 + d2;
					res1.PrintCreature();
					
					DogAction(false);
					break;
					
				case 2:
					Console.Clear();
					
					Creature d3 = new Dog();
					Creature h3 = new Human();
					
					d3.PrintCreature();
					h3.PrintCreature();
					
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("\nAFTER MUTATION:");
					Creature res2 = d3 + h3;
					res2.PrintCreature();
					
					DogAction(false);
					break;
					
				case 3:
					Console.Clear();
					
					Creature d4 = new Dog();
					Creature b4 = new Bird();
					
					d4.PrintCreature();
					b4.PrintCreature();
					
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("\nAFTER MUTATION:");
					Creature res3 = d4 + b4;
					res3.PrintCreature();
					
					DogAction(false);
					break;	
					
				case 4:
					Console.Clear();
					MainMenu();
					break;
					
				case 5:
					break;
			}
		}
		
		public static void BirdAction(bool visible)
		{
			Bird b1 = new Bird();
			
			if(visible)
			{
				Console.Clear();
				b1.PrintCreature();
			}
			
			int command = 0;
			
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("\nCREATION GENERATOR MENU");
			Console.ResetColor();
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[1]");
			Console.ResetColor();
			Console.Write(" Bird+bird");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[2]");
			Console.ResetColor();
			Console.Write(" Bird+human");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[3]");
			Console.ResetColor();
			Console.Write(" Bird+dog");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[4]");
			Console.ResetColor();
			Console.Write(" Go back");
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n[5]");
			Console.ResetColor();
			Console.Write(" Exit");
			
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("\n\nEnter a command: ");
			Console.ResetColor();
			try
			{
				command = Convert.ToInt32(Console.ReadLine());
			}
			catch(System.FormatException e)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("\nSYSTEM FORMAT EXCEPTION: ");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(e.StackTrace);
				Console.ResetColor();
				
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("\n\nTap to continue...");
				Console.ReadKey(true);
			}
			
			switch(command)
			{
				case 1:
					Console.Clear();
					
					Bird b2 = new Bird();
					b1.PrintCreature();
					b2.PrintCreature();
					
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("\nAFTER MUTATION:");
					Bird res1 = b1 + b2;
					res1.PrintCreature();
					
					BirdAction(false);
					break;
					
				case 2:
					Console.Clear();
					
					Creature b3 = new Bird();
					Creature h3 = new Human();
					
					b3.PrintCreature();
					h3.PrintCreature();
					
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("\nAFTER MUTATION:");
					Creature res2 = b3 + h3;
					res2.PrintCreature();
					
					BirdAction(false);
					break;
					
				case 3:
					Console.Clear();
					
					Creature d4 = new Dog();
					Creature b4 = new Bird();
					
					d4.PrintCreature();
					b4.PrintCreature();
					
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("\nAFTER MUTATION:");
					Creature res3 = d4 + b4;
					res3.PrintCreature();
					
					DogAction(false);
					break;	
					
				case 4:
					Console.Clear();
					DogAction(false);
					break;
					
				case 5:
					break;
			}
		}
	}
