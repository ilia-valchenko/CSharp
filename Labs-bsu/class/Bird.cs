using System;

class Bird:Creature
	{
		private Break bird_break;
		private WaterfowlBird waterfowl;
		
		public Bird()
		{	
			base.name = "bird";
			base.motion = new Motion(TypeMotion.fly, Tools.RandomBool());
			base.cover = new Cover(TypeCover.plumage, Tools.RandomBool());
			base.food = new Food(TypeFood.omnivore, Tools.RandomBool());
			base.eyes = new Eyes((ColorEyes)Tools.RandomNumber(ColorEyes.GetNames(typeof(ColorEyes)).Length), Tools.RandomBool());
			base.hair = new Hair((ColorHair)Tools.RandomNumber(ColorHair.GetNames(typeof(ColorHair)).Length), Tools.RandomBool());
			// features
			bird_break = new Break((TypeBreak)Tools.RandomNumber(TypeBreak.GetNames(typeof(TypeBreak)).Length), Tools.RandomBool());
			waterfowl = new WaterfowlBird(Tools.RandomBool(), Tools.RandomBool());
		}
		
		public Bird(Eyes eyes, Hair hair, Break bird_break, WaterfowlBird waterfowl)
		{	
			base.name = "bird";
			base.motion = new Motion(TypeMotion.fly, Tools.RandomBool());
			base.cover = new Cover(TypeCover.plumage, Tools.RandomBool());
			base.food = new Food(TypeFood.omnivore, Tools.RandomBool());
			//features
			base.eyes = new Eyes(eyes.Color_eyes, eyes.Dominant);
			base.hair = new Hair(hair.Color_hair, hair.Dominant);
			this.bird_break = new Break(bird_break.Type_break, bird_break.Dominant);
			this.waterfowl = new WaterfowlBird(waterfowl.IsWaterfowl, waterfowl.Dominant);
		}
		
		public override void PrintCreature()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\nPRINT YOUR BIRD:");
			Console.ResetColor();
			Console.Write("Name: ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(name);
			Console.ResetColor();
			Console.WriteLine(
							  "\nType motion: " + motion.Type_motion + " (" + motion.Dominant + ")" + 
							  "\nType cover: " + cover.Type_cover + " (" + cover.Dominant + ")" +
							  "\nType food: " + food.Type_food + " (" + food.Dominant + ")" +
			                  "\nEyes color: " + eyes.Color_eyes + " (" + eyes.Dominant + ")" + 
			                  "\nPlumage color: " + hair.Color_hair + " (" + hair.Dominant + ")" + 
			                  "\nIs waterfowl: " + waterfowl.IsWaterfowl + " (" + waterfowl.Dominant + ")" +
			                  "\nType break: " + bird_break.Type_break + " (" + bird_break.Dominant + ")"
 			                  );
		}
		
		public static Bird operator + (Bird bird1, Bird bird2)
		{ 		
			// выберем цвет глаз 
			Eyes new_eyes;
			
			if(bird1.eyes.Dominant)
			{
				if(bird2.eyes.Dominant) 
				{
					if(Tools.RandomBool())
						new_eyes = new Eyes(bird1.eyes.Color_eyes, bird1.eyes.Dominant); 
					else 
						new_eyes = new Eyes(bird2.eyes.Color_eyes, bird2.eyes.Dominant);
				}
				else 
					new_eyes = new Eyes(bird1.eyes.Color_eyes, bird1.eyes.Dominant);
			}
			else 
			{
				if(bird2.eyes.Dominant) 
					new_eyes = new Eyes(bird2.eyes.Color_eyes, bird2.eyes.Dominant);
				else 
				{
					if(Tools.RandomBool())
						new_eyes = new Eyes(bird1.eyes.Color_eyes, bird1.eyes.Dominant);
					else
						new_eyes = new Eyes(bird2.eyes.Color_eyes, bird2.eyes.Dominant);
				}
			}
			
			// выберем цвет волос
			Hair new_hair;
			
			if(bird1.hair.Dominant)
			{
				if(bird2.hair.Dominant) 
				{
					if(Tools.RandomBool())
						new_hair = new Hair(bird1.hair.Color_hair, bird1.hair.Dominant); 
					else 
						new_hair = new Hair(bird2.hair.Color_hair, bird2.hair.Dominant);
				}
				else 
					new_hair = new Hair(bird1.hair.Color_hair, bird1.hair.Dominant);
			}
			else 
			{
				if(bird2.hair.Dominant) 
					new_hair = new Hair(bird2.hair.Color_hair, bird2.hair.Dominant);
				else 
				{
					if(Tools.RandomBool())
						new_hair = new Hair(bird1.hair.Color_hair, bird1.hair.Dominant);
					else
						new_hair = new Hair(bird2.hair.Color_hair, bird2.hair.Dominant);
				}
			}
			
			// Выберем тип клюва
			Break new_break;
			
			if(bird1.bird_break.Dominant)
			{
				if(bird2.bird_break.Dominant) 
				{
					if(Tools.RandomBool())
						new_break = new Break(bird1.bird_break.Type_break, bird1.bird_break.Dominant); 
					else 
						new_break = new Break(bird2.bird_break.Type_break, bird2.bird_break.Dominant);
				}
				else 
					new_break = new Break(bird1.bird_break.Type_break, bird1.bird_break.Dominant);
			}
			else 
			{
				if(bird2.bird_break.Dominant) 
					new_break = new Break(bird2.bird_break.Type_break, bird2.bird_break.Dominant);
				else 
				{
					if(Tools.RandomBool())
						new_break = new Break(bird1.bird_break.Type_break, bird1.bird_break.Dominant);
					else
						new_break = new Break(bird2.bird_break.Type_break, bird2.bird_break.Dominant);
				}
			}
			
			// Водоплавающая или нет
			WaterfowlBird new_waterfowl;
			
			if(bird1.waterfowl.Dominant)
			{
				if(bird2.waterfowl.Dominant) 
				{
					if(Tools.RandomBool())
						new_waterfowl = new WaterfowlBird(bird1.waterfowl.IsWaterfowl, bird1.waterfowl.Dominant); 
					else 
						new_waterfowl = new WaterfowlBird(bird2.waterfowl.IsWaterfowl, bird2.waterfowl.Dominant);
				}
				else 
					new_waterfowl = new WaterfowlBird(bird1.waterfowl.IsWaterfowl, bird1.waterfowl.Dominant);
			}
			else 
			{
				if(bird2.waterfowl.Dominant) 
					new_waterfowl = new WaterfowlBird(bird2.waterfowl.IsWaterfowl, bird2.waterfowl.Dominant);
				else 
				{
					if(Tools.RandomBool())
						new_waterfowl = new WaterfowlBird(bird1.waterfowl.IsWaterfowl, bird1.waterfowl.Dominant);
					else
						new_waterfowl = new WaterfowlBird(bird2.waterfowl.IsWaterfowl, bird2.waterfowl.Dominant);
				}
			}
			
			return new Bird(new_eyes, new_hair, new Break(new_break.Type_break, new_break.Dominant), new WaterfowlBird(new_waterfowl.IsWaterfowl, new_waterfowl.Dominant));
		}
		
		public static implicit operator Human(Bird bird)
		{	
			return new Human(
							(TypeRace)Tools.RandomNumber(TypeRace.GetNames(typeof(TypeRace)).Length),
						   new Eyes(bird.Eyes.Color_eyes, bird.Eyes.Dominant), 
						   new Hair(bird.Hair.Color_hair, bird.Hair.Dominant)
						   );
		}
		
		public static implicit operator Dog(Bird bird)
		{
			return new Dog(
						   new Eyes(bird.Eyes.Color_eyes, bird.Eyes.Dominant), 
			               new Hair(bird.Hair.Color_hair, bird.Hair.Dominant),
			               new Tail((TypeTail)Tools.RandomNumber(TypeTail.GetNames(typeof(TypeTail)).Length), Tools.RandomBool()),
			               new Muzzle((TypeMuzzle)Tools.RandomNumber(TypeMuzzle.GetNames(typeof(TypeMuzzle)).Length), Tools.RandomBool()),
			               new Ears((TypeEars)Tools.RandomNumber(TypeEars.GetNames(typeof(TypeEars)).Length), Tools.RandomBool())
						   );
		}
	}
