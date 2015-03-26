using System;

class Human:Creature
	{
		private TypeRace race;
		
		public Human(TypeRace race, Eyes eyes, Hair hair)
		{	
			this.race = race;
			base.name = "human";
			base.eyes = eyes;
			base.hair = hair;
			base.motion = new Motion(TypeMotion.foot, Tools.RandomBool());
			base.cover = new Cover(TypeCover.leather, Tools.RandomBool());
			base.food = new Food(TypeFood.omnivore, Tools.RandomBool());
		}
		
		public Human()
		{			
			base.name = "human";
			base.motion = new Motion(TypeMotion.foot, Tools.RandomBool());
			base.cover = new Cover(TypeCover.leather, Tools.RandomBool());
			base.food = new Food(TypeFood.omnivore, Tools.RandomBool());
			base.eyes = new Eyes((ColorEyes)Tools.RandomNumber(ColorEyes.GetNames(typeof(ColorEyes)).Length), Tools.RandomBool());
			base.hair = new Hair((ColorHair)Tools.RandomNumber(ColorHair.GetNames(typeof(ColorHair)).Length), Tools.RandomBool());
			// features
			race = (TypeRace)Tools.RandomNumber(TypeRace.GetNames(typeof(TypeRace)).Length-4); // вычитает расы, получаемые в результате смшенения
		}
		
		public override void PrintCreature()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\nPRINT YOUR HUMAN:");
			Console.ResetColor();
			Console.Write("Name: ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(name);
			Console.ResetColor();
			Console.WriteLine( 
			                  "\nType motion: " + motion.Type_motion + " (" + motion.Dominant + ")" + 
							  "\nType cover: " + cover.Type_cover + " (" + cover.Dominant + ")" +
							  "\nType food: " + food.Type_food + " (" + food.Dominant + ")" +
			                  "\nRace: " + race + 
			                  "\nEyes color: " + eyes.Color_eyes + " (" + eyes.Dominant + ")" + 
			                  "\nHair color: " + hair.Color_hair + " (" + hair.Dominant + ")" 
			                  );
			
		}
		
		public static Human operator + (Human human1, Human human2)
		{ 		
			// выберем цвет глаз 
			Eyes new_eyes;
			
			if(human1.eyes.Dominant)
			{
				if(human2.eyes.Dominant) 
				{
					if(Tools.RandomBool())
						new_eyes = new Eyes(human1.eyes.Color_eyes, human1.eyes.Dominant); 
					else 
						new_eyes = new Eyes(human2.eyes.Color_eyes, human2.eyes.Dominant);
				}
				else 
					new_eyes = new Eyes(human1.eyes.Color_eyes, human1.eyes.Dominant);
			}
			else 
			{
				if(human2.eyes.Dominant) 
					new_eyes = new Eyes(human2.eyes.Color_eyes, human2.eyes.Dominant);
				else 
				{
					if(Tools.RandomBool())
						new_eyes = new Eyes(human1.eyes.Color_eyes, human1.eyes.Dominant);
					else
						new_eyes = new Eyes(human2.eyes.Color_eyes, human2.eyes.Dominant);
				}
			}
			
			// выберем цвет волос
			Hair new_hair;
			
			if(human1.hair.Dominant)
			{
				if(human2.hair.Dominant) 
				{
					if(Tools.RandomBool())
						new_hair = new Hair(human1.hair.Color_hair, human1.hair.Dominant); 
					else 
						new_hair = new Hair(human2.hair.Color_hair, human2.hair.Dominant);
				}
				else 
					new_hair = new Hair(human1.hair.Color_hair, human1.hair.Dominant);
			}
			else 
			{
				if(human2.hair.Dominant) 
					new_hair = new Hair(human2.hair.Color_hair, human2.hair.Dominant);
				else 
				{
					if(Tools.RandomBool())
						new_hair = new Hair(human1.hair.Color_hair, human1.hair.Dominant);
					else
						new_hair = new Hair(human2.hair.Color_hair, human2.hair.Dominant);
				}
			}
			
			//получим новую расу
			TypeRace new_race = TypeRace.europid;
			
			if(human1.race == TypeRace.europid)
			{
				switch(human2.race)
				{
					case TypeRace.europid:
						new_race = TypeRace.europid;
						break;
						
					case TypeRace.negroid:
						new_race = TypeRace.mulatto;
						break;
						
					case TypeRace.indigenous:
						new_race = TypeRace.mestizo;
						break;
						
					case TypeRace.asian:
						new_race = TypeRace.mestizo;
						break;
				}
			}
			
			if(human1.race == TypeRace.negroid)
			{
				switch(human2.race)
				{
					case TypeRace.negroid:
						new_race = TypeRace.negroid;
						break;
						
					case TypeRace.europid:
						new_race = TypeRace.mulatto;
						break;

					case TypeRace.indigenous:
						new_race = TypeRace.zambo;
						break;
						
					case TypeRace.asian:
						new_race = TypeRace.mestizo;
						break;
				}
			}
			
			if(human1.race == TypeRace.asian)
			{
				switch(human2.race)
				{
					case TypeRace.asian:
						new_race = TypeRace.asian;
						break;
						
					case TypeRace.europid:
						new_race = TypeRace.mestizo;
						break;
						
					case TypeRace.negroid:
						new_race = TypeRace.mestizo;
						break;
						
					case TypeRace.indigenous:
						new_race = TypeRace.mestizo;
						break;
				}
			}
			
			if(human1.race == TypeRace.indigenous)
			{
				switch(human2.race)
				{
					case TypeRace.indigenous:
						new_race = TypeRace.indigenous;
						break;
						
					case TypeRace.europid:
						new_race = TypeRace.mestizo;
						break;
						
					case TypeRace.negroid:
						new_race = TypeRace.zambo;
						break;
						
					case TypeRace.asian:
						new_race = TypeRace.mestizo;
						break;
				}
			}
			
			return new Human(new_race, new_eyes, new_hair);
		}
		
		// ОПЕРАТОРЫ ПРЕОБРАЗОВАНИЯ
		
		public static implicit operator Dog(Human human)
		{
			var rand = new Random(DateTime.Now.Millisecond);
			
			return new Dog(new Eyes(human.Eyes.Color_eyes, human.Eyes.Dominant), 
			               new Hair(human.Hair.Color_hair, human.Hair.Dominant),
			               new Tail((TypeTail)Tools.RandomNumber(TypeTail.GetNames(typeof(TypeTail)).Length), Tools.RandomBool()),
			               new Muzzle((TypeMuzzle)Tools.RandomNumber(TypeMuzzle.GetNames(typeof(TypeMuzzle)).Length), Tools.RandomBool()),
			               new Ears((TypeEars)Tools.RandomNumber(TypeEars.GetNames(typeof(TypeEars)).Length), Tools.RandomBool())
						  );
		}
		
		public static implicit operator Bird(Human human)
		{
			var rand = new Random(DateTime.Now.Millisecond);
			
			return new Bird(
						   new Eyes(human.Eyes.Color_eyes, human.Eyes.Dominant), 
			               new Hair(human.Hair.Color_hair, human.Hair.Dominant),
			               new Break((TypeBreak)Tools.RandomNumber(TypeBreak.GetNames(typeof(TypeBreak)).Length), Tools.RandomBool()),
			               new WaterfowlBird(Tools.RandomBool(), Tools.RandomBool())
						   );
		}
	}