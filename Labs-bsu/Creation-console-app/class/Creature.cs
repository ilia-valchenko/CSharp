using System;

class Creature 
	{
		protected string name = "unknown species of ";
		protected Motion motion;
		protected Cover cover;
		protected Food food;
		protected Eyes eyes;
		protected Hair hair; 
		
		public Creature(string name, Motion motion, Cover cover, Food food, Eyes eyes, Hair hair)
		{	
			this.name = name;
			this.motion = new Motion(motion.Type_motion, motion.Dominant);
			this.cover = new Cover(cover.Type_cover, motion.Dominant);
			this.food = new Food(food.Type_food, food.Dominant);
			this.eyes = new Eyes(eyes.Color_eyes, eyes.Dominant);
			this.hair = new Hair(hair.Color_hair, hair.Dominant);
		}
		
		public Creature()
		{	
			motion = new Motion((TypeMotion)Tools.RandomNumber(TypeMotion.GetNames(typeof(TypeMotion)).Length), Tools.RandomBool());
			cover = new Cover((TypeCover)Tools.RandomNumber(TypeCover.GetNames(typeof(TypeCover)).Length), Tools.RandomBool());
			food = new Food((TypeFood)Tools.RandomNumber(TypeFood.GetNames(typeof(TypeFood)).Length), Tools.RandomBool());
			eyes = new Eyes((ColorEyes)Tools.RandomNumber(ColorEyes.GetNames(typeof(ColorEyes)).Length), Tools.RandomBool());
			hair = new Hair((ColorHair)Tools.RandomNumber(ColorHair.GetNames(typeof(ColorHair)).Length), Tools.RandomBool());
			
			// select the type of movement
			switch(motion.Type_motion)
			{
				case TypeMotion.foot:
					name += TypeName.mammal;
					break;
					
				case TypeMotion.fly:
					name += TypeName.bird;
					break;
					
				case TypeMotion.swim:
					name += TypeName.waterfowl;
					break;
					
				case TypeMotion.creep:
					name += TypeName.reptile;
					break;
			}
		}
		
		public Creature(Creature creature)
		{
			this.name = creature.name;
			this.motion = creature.motion;
			this.cover = creature.cover;
			this.food = creature.food;
			this.eyes = creature.eyes;
			this.hair = creature.hair;
		}
		
		public string Name
		{
			get
			{
				return name;
			}
		}
		
		public Motion Motion
		{
			get
			{
				return motion;
			}
		}
		
		public Cover Cover
		{
			get
			{
				return cover;
			}
		}
		
		public Food Food
		{
			get
			{
				return food;
			}
		}
		
		public Eyes Eyes
		{
			get
			{
				return eyes;
			}
		}
		
		public Hair Hair
		{
			get
			{
				return hair;
			}
		}
		
		public virtual void PrintCreature()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\nPRINT YOUR CREATURE:");
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
			              "\nHair/Wool/Plumage color: " + hair.Color_hair + " (" + hair.Dominant + ")"
			             );
		}
		
		public static Creature operator + (Creature creature1, Creature creature2)
		{	
			// создадим новое имя существу
			//string new_name = creature1.name.Substring(creature1.name.Length/2) + creature2.name.Substring(creature2.name.Length/2);
			string new_name = "unknown species of ";

			// выберем тип передвижения существа
			Motion new_motion;
			
			if(creature1.motion.Dominant)
			{
				if(creature2.motion.Dominant) // если оба типа передвижения доминантны 
				{
					// тогда выберем случайный
					if(Tools.RandomBool())
						new_motion = new Motion(creature1.motion.Type_motion, Tools.RandomBool()); // пусть у каждого нового существа все признаки будут рецессивными
					else 
						new_motion = new Motion(creature2.motion.Type_motion, Tools.RandomBool());
				}
				else // если у воторого существа этот признак рецессивный
					new_motion = new Motion(creature1.motion.Type_motion, Tools.RandomBool());
			}
			else // если у первого существа этот признак рецессивный
			{
				if(creature2.motion.Dominant) // а у второго - нет
					new_motion = new Motion(creature2.motion.Type_motion, Tools.RandomBool());
				else // если у обоих существ признаки рецессивные
				{
					if(Tools.RandomBool())
						new_motion = new Motion(creature1.motion.Type_motion, Tools.RandomBool());
					else
						new_motion = new Motion(creature2.motion.Type_motion, Tools.RandomBool());
				}
			}
			
			switch(new_motion.Type_motion)
			{
				case TypeMotion.foot:
					new_name += TypeName.mammal;
					break;
					
				case TypeMotion.fly:
					new_name += TypeName.bird;
					break;
					
				case TypeMotion.swim:
					new_name += TypeName.waterfowl;
					break;
					
				case TypeMotion.creep:
					new_name += TypeName.reptile;
					break;
			}
			
			// выберем тип покрова существа
			Cover new_cover;
			
			if(creature1.cover.Dominant)
			{
				if(creature2.cover.Dominant)  
				{
					if(Tools.RandomBool())
						new_cover = new Cover(creature1.cover.Type_cover, Tools.RandomBool());
					else 
						new_cover = new Cover(creature2.cover.Type_cover, Tools.RandomBool());
				}
				else 
					new_cover = new Cover(creature1.cover.Type_cover, Tools.RandomBool());
			}
			else 
			{
				if(creature2.cover.Dominant) 
					new_cover = new Cover(creature2.cover.Type_cover, Tools.RandomBool());
				else 
				{
					if(Tools.RandomBool())
						new_cover = new Cover(creature1.cover.Type_cover, Tools.RandomBool());
					else
						new_cover = new Cover(creature2.cover.Type_cover, Tools.RandomBool());
				}
			}
			
			// выберем тип питания существа
			Food new_food;
			
			if(creature1.food.Dominant)
			{
				if(creature2.food.Dominant) 
				{
					if(Tools.RandomBool())
						new_food = new Food(creature1.food.Type_food, Tools.RandomBool());
					else 
						new_food = new Food(creature2.food.Type_food, Tools.RandomBool());
				}
				else 
					new_food = new Food(creature1.food.Type_food, Tools.RandomBool());
			}
			else 
			{
				if(creature2.food.Dominant) 
					new_food = new Food(creature2.food.Type_food, Tools.RandomBool());
				else 
				{
					if(Tools.RandomBool())
						new_food = new Food(creature1.food.Type_food, Tools.RandomBool());
					else
						new_food = new Food(creature2.food.Type_food, Tools.RandomBool());
				}
			}
			
			// выберем цвет глаз нового существа
			Eyes new_eyes;
			
			if(creature1.eyes.Dominant)
			{
				if(creature2.eyes.Dominant) 
				{
					if(Tools.RandomBool())
						new_eyes = new Eyes(creature1.eyes.Color_eyes, Tools.RandomBool()); 
					else 
						new_eyes = new Eyes(creature2.eyes.Color_eyes, Tools.RandomBool());
				}
				else 
					new_eyes = new Eyes(creature1.eyes.Color_eyes, Tools.RandomBool());
			}
			else 
			{
				if(creature2.eyes.Dominant) 
					new_eyes = new Eyes(creature2.eyes.Color_eyes, Tools.RandomBool());
				else 
				{
					if(Tools.RandomBool())
						new_eyes = new Eyes(creature1.eyes.Color_eyes, Tools.RandomBool());
					else
						new_eyes = new Eyes(creature2.eyes.Color_eyes, Tools.RandomBool());
				}
			}
			
			// выберем цвет волос/шерсти/перьев
			Hair new_hair;
			
			if(creature1.hair.Dominant)
			{
				if(creature2.hair.Dominant) 
				{
					if(Tools.RandomBool())
						new_hair = new Hair(creature1.hair.Color_hair, Tools.RandomBool()); 
					else 
						new_hair = new Hair(creature2.hair.Color_hair, Tools.RandomBool());
				}
				else 
					new_hair = new Hair(creature1.hair.Color_hair, Tools.RandomBool());
			}
			else 
			{
				if(creature2.hair.Dominant) 
					new_hair = new Hair(creature2.hair.Color_hair, Tools.RandomBool());
				else 
				{
					if(Tools.RandomBool())
						new_hair = new Hair(creature1.hair.Color_hair, Tools.RandomBool());
					else
						new_hair = new Hair(creature2.hair.Color_hair, Tools.RandomBool());
				}
			}
			
			return new Creature(new_name, new_motion, new_cover, new_food, new_eyes, new_hair);
		}
	}
