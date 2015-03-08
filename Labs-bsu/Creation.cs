/*
 * Created by SharpDevelop.
 * User: IliA
 * Date: 01.03.2015
 * Time: 19:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Creation
{
	public enum TypeMotion {foot, fly, swim, creep};
	public enum TypeCover {leather, wool, scales, plumage};
	public enum TypeFood {carnivore, herbivore, omnivore};
	public enum ColorEyes {blue, grey, green, amber, swamp, brown, black, yellow};
	public enum ColorHair {white, black, brown, golden};
	public enum TypeName {mammal, bird, waterfowl, reptile};
	// human
	public enum TypeRace {europid, negroid, indigenous, asian, mestizo, mulatto, zambo}; 
	// dog
	public enum TypeTail {bagel, saber, hook, rod, sickle, ring, bobtailed}; // бубликом, саблевидный, крючком, прутом, серпом, кольцевидный, бубликом, куцый
	public enum TypeMuzzle {gaunt, brief, pointed, blunt}; // длинная, короткая, заостренная, тупая
	public enum TypeEars {prick_ears, hanging_ears, semi_prick_ears}; // стоячие уши, висячие уши, полустоячие уши
	// bird
	public enum TypeBreak {predatory, water, granivorous, insectivorous}; // хищный, водный, травоядный насекомоядный
	
	public struct Motion
	{	
    	private TypeMotion type_motion;
    	private bool dominant;

    	public Motion(TypeMotion type_motion, bool dominant)
	    {
	        this.type_motion = type_motion;
	        this.dominant = dominant;
	    }
    	
    	public TypeMotion Type_motion
    	{
    		set
    		{
    			type_motion = value;
    		}
    		get
    		{
    			return type_motion;
    		}
    	}
    	
    	public bool Dominant
    	{
    		set
    		{
    			dominant = value;
    		}
    		get
    		{
    			return dominant;
    		}
    	}
	}
	
	public struct Cover
	{
		private TypeCover type_cover;
		private bool dominant;
		
		public Cover(TypeCover type_cover, bool dominant)
		{
			this.type_cover = type_cover;
			this.dominant = dominant;
		}
		
		public TypeCover Type_cover
		{
			get
			{
				return type_cover;
			}
		}
		
		public bool Dominant
    	{
    		get
    		{
    			return dominant;
    		}
    	}
	}
	
	public struct Food
	{
		private TypeFood type_food;
		private bool dominant;
		
		public Food(TypeFood type_food, bool dominant)
		{
			this.type_food = type_food;
			this.dominant = dominant;
		}
		
		public TypeFood Type_food
		{
			get
			{
				return type_food;
			}
		}
		
		public bool Dominant
    	{
    		get
    		{
    			return dominant;
    		}
    	}
	}
	
	public struct Eyes
	{
		private ColorEyes color_eyes;
		private bool dominant;
		
		public Eyes(ColorEyes color_eyes, bool dominant)
		{
			this.color_eyes = color_eyes;
			this.dominant = dominant;
		}
		
		public ColorEyes Color_eyes
		{
			get
			{
				return color_eyes;
			}
		}
		
		public bool Dominant
    	{
    		get
    		{
    			return dominant;
    		}
    	}
	}
	
	public struct Hair
	{
		private ColorHair color_hair;
		private bool dominant;
		
		public Hair(ColorHair color_hair, bool dominant)
		{
			this.color_hair = color_hair;
			this.dominant = dominant;
		}
		
		public ColorHair Color_hair
		{
			get
			{
				return color_hair;
			}
		}
		
		public bool Dominant
    	{
    		get
    		{
    			return dominant;
    		}
    	}
	}
	
	public struct Tail
	{
		private TypeTail type_tail;
		private bool dominant;
		
		public Tail(TypeTail type_tail, bool dominant)
		{
			this.type_tail = type_tail;
			this.dominant = dominant;
		}
		
		public TypeTail Type_tail
		{
			get
			{
				return type_tail;
			}
		}
		
		public bool Dominant
    	{
    		get
    		{
    			return dominant;
    		}
    	}
	}
	
	public struct Muzzle
	{
		private TypeMuzzle type_muzzle;
		private bool dominant;
		
		public Muzzle(TypeMuzzle type_muzzle, bool dominant)
		{
			this.type_muzzle = type_muzzle;
			this.dominant = dominant;
		}
		
		public TypeMuzzle Type_muzzle
		{
			get
			{
				return type_muzzle;
			}
		}
		
		public bool Dominant
    	{
    		get
    		{
    			return dominant;
    		}
    	}
	}
	
	public struct Ears
	{
		private TypeEars type_ears;
		private bool dominant;
		
		public Ears(TypeEars type_ears, bool dominant)
		{
			this.type_ears = type_ears;
			this.dominant = dominant;
		}
		
		public TypeEars Type_ears
		{
			get
			{
				return type_ears;
			}
		}
		
		public bool Dominant
    	{
    		get
    		{
    			return dominant;
    		}
    	}
	}
	
	public struct Break
	{
		private TypeBreak type_break;
		private bool dominant;
		
		public Break(TypeBreak type_break, bool dominant)
		{
			this.type_break = type_break;
			this.dominant = dominant;
		}
		
		public TypeBreak Type_break
		{
			get
			{
				return type_break;
			}
		}
		
		public bool Dominant
		{
			get
			{
				return dominant;
			}
		}
	}
	
	public struct WaterfowlBird
	{
		private bool isWaterfowl;
		private bool dominant;
		
		public WaterfowlBird(bool isWaterfowl, bool dominant)
		{
			this.isWaterfowl = isWaterfowl;
			this.dominant = dominant;
		}
		
		public bool IsWaterfowl
		{
			get
			{
				return isWaterfowl;
			}
		}
		
		public bool Dominant
		{
			get
			{
				return dominant;
			}
		}	
	}
	
	static class Tools
    {
        public static int RandomNumber(int end)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            return rand.Next(0, end);
        }
        
        public static bool RandomBool()
        {
        	if(RandomNumber(2) == 0)
        		return true;
        	else 
        		return false;
        }
    }
	
	class Creature // private default
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
			var rand = new Random(DateTime.Now.Millisecond);
			
			motion = new Motion((TypeMotion)rand.Next(0, TypeMotion.GetNames(typeof(TypeMotion)).Length), RandomBool(rand.Next(0, 2)));
			cover = new Cover((TypeCover)rand.Next(0, TypeCover.GetNames(typeof(TypeCover)).Length), RandomBool(rand.Next(0, 2)));
			food = new Food((TypeFood)rand.Next(0, TypeFood.GetNames(typeof(TypeFood)).Length), RandomBool(rand.Next(0, 2)));
			eyes = new Eyes((ColorEyes)rand.Next(0, ColorEyes.GetNames(typeof(ColorEyes)).Length), RandomBool(rand.Next(0, 2)));
			hair = new Hair((ColorHair)rand.Next(0, ColorHair.GetNames(typeof(ColorHair)).Length), RandomBool(rand.Next(0, 2)));
			
			/*
			motion = new Motion((TypeMotion)Tools.RandomNumber(TypeMotion.GetNames(typeof(TypeMotion)).Length), Tools.RandomBool());
			cover = new Cover((TypeCover)Tools.RandomNumber(TypeCover.GetNames(typeof(TypeCover)).Length), Tools.RandomBool());
			food = new Food((TypeFood)Tools.RandomNumber(TypeFood.GetNames(typeof(TypeFood)).Length), Tools.RandomBool());
			eyes = new Eyes((ColorEyes)Tools.RandomNumber(ColorEyes.GetNames(typeof(ColorEyes)).Length), Tools.RandomBool());
			hair = new Hair((ColorHair)Tools.RandomNumber(ColorHair.GetNames(typeof(ColorHair)).Length), Tools.RandomBool());
			*/
			
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
        
        public static bool RandomBool(int rand)
        {
        	if(rand == 0)
        		return true;
        	else 
        		return false;
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
			              "\nHair color: " + hair.Color_hair + " (" + hair.Dominant + ")"
			             );
		}
		
		public static Creature operator + (Creature creature1, Creature creature2)
		{
			var rand = new Random(DateTime.Now.Millisecond);
			
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
					if(RandomBool(rand.Next(0,2)))
						new_motion = new Motion(creature1.motion.Type_motion, RandomBool(rand.Next(0,2))); // пусть у каждого нового существа все признаки будут рецессивными
					else 
						new_motion = new Motion(creature2.motion.Type_motion, RandomBool(rand.Next(0,2)));
				}
				else // если у воторого существа этот признак рецессивный
					new_motion = new Motion(creature1.motion.Type_motion, RandomBool(rand.Next(0,2)));
			}
			else // если у первого существа этот признак рецессивный
			{
				if(creature2.motion.Dominant) // а у второго - нет
					new_motion = new Motion(creature2.motion.Type_motion, RandomBool(rand.Next(0,2)));
				else // если у обоих существ признаки рецессивные
				{
					if(RandomBool(rand.Next(0,2)))
						new_motion = new Motion(creature1.motion.Type_motion, RandomBool(rand.Next(0,2)));
					else
						new_motion = new Motion(creature2.motion.Type_motion, RandomBool(rand.Next(0,2)));
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
					if(RandomBool(rand.Next(0,2)))
						new_cover = new Cover(creature1.cover.Type_cover, RandomBool(rand.Next(0,2))); 
					else 
						new_cover = new Cover(creature2.cover.Type_cover, RandomBool(rand.Next(0,2)));
				}
				else 
					new_cover = new Cover(creature1.cover.Type_cover, RandomBool(rand.Next(0,2)));
			}
			else 
			{
				if(creature2.cover.Dominant) 
					new_cover = new Cover(creature2.cover.Type_cover, RandomBool(rand.Next(0,2)));
				else 
				{
					if(RandomBool(rand.Next(0,2)))
						new_cover = new Cover(creature1.cover.Type_cover, RandomBool(rand.Next(0,2)));
					else
						new_cover = new Cover(creature2.cover.Type_cover, RandomBool(rand.Next(0,2)));
				}
			}
			
			// выберем тип питания существа
			Food new_food;
			
			if(creature1.food.Dominant)
			{
				if(creature2.food.Dominant) 
				{
					if(RandomBool(rand.Next(0,2)))
						new_food = new Food(creature1.food.Type_food, RandomBool(rand.Next(0,2))); 
					else 
						new_food = new Food(creature2.food.Type_food, RandomBool(rand.Next(0,2)));
				}
				else 
					new_food = new Food(creature1.food.Type_food, RandomBool(rand.Next(0,2)));
			}
			else 
			{
				if(creature2.food.Dominant) 
					new_food = new Food(creature2.food.Type_food, RandomBool(rand.Next(0,2)));
				else 
				{
					if(RandomBool(rand.Next(0,2)))
						new_food = new Food(creature1.food.Type_food, RandomBool(rand.Next(0,2)));
					else
						new_food = new Food(creature2.food.Type_food, RandomBool(rand.Next(0,2)));
				}
			}
			
			// выберем цвет глаз нового существа
			Eyes new_eyes;
			
			if(creature1.eyes.Dominant)
			{
				if(creature2.eyes.Dominant) 
				{
					if(RandomBool(rand.Next(0,2)))
						new_eyes = new Eyes(creature1.eyes.Color_eyes, RandomBool(rand.Next(0,2))); 
					else 
						new_eyes = new Eyes(creature2.eyes.Color_eyes, RandomBool(rand.Next(0,2)));
				}
				else 
					new_eyes = new Eyes(creature1.eyes.Color_eyes, RandomBool(rand.Next(0,2)));
			}
			else 
			{
				if(creature2.eyes.Dominant) 
					new_eyes = new Eyes(creature2.eyes.Color_eyes, RandomBool(rand.Next(0,2)));
				else 
				{
					if(RandomBool(rand.Next(0,2)))
						new_eyes = new Eyes(creature1.eyes.Color_eyes, RandomBool(rand.Next(0,2)));
					else
						new_eyes = new Eyes(creature2.eyes.Color_eyes, RandomBool(rand.Next(0,2)));
				}
			}
			
			// выберем цвет волос/шерсти/перьев
			Hair new_hair;
			
			if(creature1.hair.Dominant)
			{
				if(creature2.hair.Dominant) 
				{
					if(RandomBool(rand.Next(0,2)))
						new_hair = new Hair(creature1.hair.Color_hair, RandomBool(rand.Next(0,2))); 
					else 
						new_hair = new Hair(creature2.hair.Color_hair, RandomBool(rand.Next(0,2)));
				}
				else 
					new_hair = new Hair(creature1.hair.Color_hair, RandomBool(rand.Next(0,2)));
			}
			else 
			{
				if(creature2.hair.Dominant) 
					new_hair = new Hair(creature2.hair.Color_hair, RandomBool(rand.Next(0,2)));
				else 
				{
					if(RandomBool(rand.Next(0,2)))
						new_hair = new Hair(creature1.hair.Color_hair, RandomBool(rand.Next(0,2)));
					else
						new_hair = new Hair(creature2.hair.Color_hair, RandomBool(rand.Next(0,2)));
				}
			}
			
			return new Creature(new_name, new_motion, new_cover, new_food, new_eyes, new_hair);
		}
	}
	
	class Human:Creature
	{
		private string name = "human"; // hide
		private TypeRace race;
		
		public Human(TypeRace race, Eyes eyes, Hair hair)
		{
			var rand = new Random(DateTime.Now.Millisecond);
			
			this.race = race;
			base.eyes = eyes;
			base.hair = hair;
			base.motion = new Motion(TypeMotion.foot, RandomBool(rand.Next(0,2)));
			base.cover = new Cover(TypeCover.leather, RandomBool(rand.Next(0,2)));
			base.food = new Food(TypeFood.omnivore, RandomBool(rand.Next(0,2)));
		}
		
		public Human()
		{
			var rand = new Random(DateTime.Now.Millisecond); 
			
			base.motion = new Motion(TypeMotion.foot, RandomBool(rand.Next(0,2)));
			base.cover = new Cover(TypeCover.leather, RandomBool(rand.Next(0,2)));
			base.food = new Food(TypeFood.omnivore, RandomBool(rand.Next(0,2)));
			base.eyes = new Eyes((ColorEyes)rand.Next(0, ColorEyes.GetNames(typeof(ColorEyes)).Length), RandomBool(rand.Next(0,2)));
			base.hair = new Hair((ColorHair)rand.Next(0, ColorHair.GetNames(typeof(ColorHair)).Length), RandomBool(rand.Next(0,2)));
			// features
			race = (TypeRace)rand.Next(0, TypeRace.GetNames(typeof(TypeRace)).Length-4); // вычитает расы, получаемые в результате смшенения
		}
		
		public string Name
		{
			get
			{
				return name;
			}
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
			                  "\nWool color: " + hair.Color_hair + " (" + hair.Dominant + ")" 
			                  );
			
		}
		
		public static Human operator + (Human human1, Human human2)
		{ 		
			var rand = new Random(DateTime.Now.Millisecond);
			
			// выберем цвет глаз 
			Eyes new_eyes;
			
			if(human1.eyes.Dominant)
			{
				if(human2.eyes.Dominant) 
				{
					if(RandomBool(rand.Next(0,2)))
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
					if(RandomBool(rand.Next(0,2)))
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
					if(RandomBool(rand.Next(0,2)))
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
					if(RandomBool(rand.Next(0,2)))
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
	}
	
	class Dog:Creature
	{
		private string name = "dog";
		private Tail tail;
		private Muzzle muzzle;
		private Ears ears;
		
		public Dog()
		{	
			var rand = new Random(DateTime.Now.Millisecond);
			
			base.motion = new Motion(TypeMotion.foot, RandomBool(rand.Next(0,2)));
			base.cover = new Cover(TypeCover.wool, RandomBool(rand.Next(0,2)));
			base.food = new Food(TypeFood.omnivore, RandomBool(rand.Next(0,2)));
			base.eyes = new Eyes((ColorEyes)rand.Next(0, ColorEyes.GetNames(typeof(ColorEyes)).Length), RandomBool(rand.Next(0,2)));
			base.hair = new Hair((ColorHair)rand.Next(0, ColorHair.GetNames(typeof(ColorHair)).Length), RandomBool(rand.Next(0,2)));
			// features
			tail = new Tail((TypeTail)rand.Next(0, TypeTail.GetNames(typeof(TypeTail)).Length), RandomBool(rand.Next(0,2)));
			muzzle = new Muzzle((TypeMuzzle)rand.Next(0, TypeMuzzle.GetNames(typeof(TypeMuzzle)).Length), RandomBool(rand.Next(0,2)));
			ears = new Ears((TypeEars)rand.Next(0, TypeEars.GetNames(typeof(TypeEars)).Length), RandomBool(rand.Next(0,2)));
		}
		
		public Dog(Eyes eyes, Hair hair, Tail tail, Muzzle muzzle, Ears ears)
		{
			var rand = new Random(DateTime.Now.Millisecond);
			
			base.eyes = new Eyes(eyes.Color_eyes, eyes.Dominant);
			base.hair = new Hair(hair.Color_hair, hair.Dominant);
			this.tail = new Tail(tail.Type_tail, tail.Dominant);
			this.muzzle = new Muzzle(muzzle.Type_muzzle, muzzle.Dominant);
			this.ears = new Ears(ears.Type_ears, ears.Dominant);
			// standard
			base.motion = new Motion(TypeMotion.foot, RandomBool(rand.Next(0,2)));
			base.cover = new Cover(TypeCover.wool, RandomBool(rand.Next(0,2)));
			base.food = new Food(TypeFood.omnivore, RandomBool(rand.Next(0,2)));
		}
		
		public string Name
		{
			get
			{
				return name;
			}
		}
		
		public override void PrintCreature()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\nPRINT YOUR DOG:");
			Console.ResetColor();
			Console.Write("Name: ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(name);
			Console.ResetColor();
			Console.WriteLine(
							  "\nType motion: " + motion.Type_motion + " (" + motion.Dominant + ")" + 
							  "\nType cover: " + cover.Type_cover + " (" + cover.Dominant + ")" +
							  "\nType food: " + food.Type_food + " (" + food.Dominant + ")" +
							  "\nType tail: " + tail.Type_tail + " (" + tail.Dominant + ")" +
							  "\nType muzzle: " + muzzle.Type_muzzle + " (" + muzzle.Dominant + ")" +
							  "\nType ears: " + ears.Type_ears + " (" + ears.Dominant + ")" +
			                  "\nEyes color: " + eyes.Color_eyes + " (" + eyes.Dominant + ")" + 
			                  "\nHair color: " + hair.Color_hair + " (" + hair.Dominant + ")"
			                  );
		}
		
		public static Dog operator + (Dog dog1, Dog dog2)
		{ 	
			var rand = new Random(DateTime.Now.Millisecond);
			
			// выберем цвет глаз 
			Eyes new_eyes;
			
			if(dog1.eyes.Dominant)
			{
				if(dog2.eyes.Dominant) 
				{
					if(RandomBool(rand.Next(0,2)))
						new_eyes = new Eyes(dog1.eyes.Color_eyes, dog1.eyes.Dominant); 
					else 
						new_eyes = new Eyes(dog2.eyes.Color_eyes, dog2.eyes.Dominant);
				}
				else 
					new_eyes = new Eyes(dog1.eyes.Color_eyes, dog1.eyes.Dominant);
			}
			else 
			{
				if(dog2.eyes.Dominant) 
					new_eyes = new Eyes(dog2.eyes.Color_eyes, dog2.eyes.Dominant);
				else 
				{
					if(RandomBool(rand.Next(0,2)))
						new_eyes = new Eyes(dog1.eyes.Color_eyes, dog1.eyes.Dominant);
					else
						new_eyes = new Eyes(dog2.eyes.Color_eyes, dog2.eyes.Dominant);
				}
			}
			
			// выберем цвет волос
			Hair new_hair;
			
			if(dog1.hair.Dominant)
			{
				if(dog2.hair.Dominant) 
				{
					if(RandomBool(rand.Next(0,2)))
						new_hair = new Hair(dog1.hair.Color_hair, dog1.hair.Dominant); 
					else 
						new_hair = new Hair(dog2.hair.Color_hair, dog2.hair.Dominant);
				}
				else 
					new_hair = new Hair(dog1.hair.Color_hair, dog1.hair.Dominant);
			}
			else 
			{
				if(dog2.hair.Dominant) 
					new_hair = new Hair(dog2.hair.Color_hair, dog2.hair.Dominant);
				else 
				{
					if(RandomBool(rand.Next(0,2)))
						new_hair = new Hair(dog1.hair.Color_hair, dog1.hair.Dominant);
					else
						new_hair = new Hair(dog2.hair.Color_hair, dog2.hair.Dominant);
				}
			}
			
			// выберем тип хвоста
			Tail new_tail;
			
			if(dog1.tail.Dominant)
			{
				if(dog2.tail.Dominant) 
				{
					if(RandomBool(rand.Next(0,2)))
						new_tail = new Tail(dog1.tail.Type_tail, dog1.tail.Dominant); 
					else 
						new_tail = new Tail(dog2.tail.Type_tail, dog2.tail.Dominant);
				}
				else 
					new_tail = new Tail(dog1.tail.Type_tail, dog1.tail.Dominant);
			}
			else 
			{
				if(dog2.tail.Dominant) 
					new_tail = new Tail(dog2.tail.Type_tail, dog2.tail.Dominant);
				else 
				{
					if(RandomBool(rand.Next(0,2)))
						new_tail = new Tail(dog1.tail.Type_tail, dog1.tail.Dominant);
					else
						new_tail = new Tail(dog2.tail.Type_tail, dog2.tail.Dominant);
				}
			}
			
			// выберем форму морды
			Muzzle new_muzzle;
			
			if(dog1.muzzle.Dominant)
			{
				if(dog2.muzzle.Dominant) 
				{
					if(RandomBool(rand.Next(0,2)))
						new_muzzle = new Muzzle(dog1.muzzle.Type_muzzle, dog1.muzzle.Dominant); 
					else 
						new_muzzle = new Muzzle(dog2.muzzle.Type_muzzle, dog2.muzzle.Dominant);
				}
				else 
					new_muzzle = new Muzzle(dog1.muzzle.Type_muzzle, dog1.muzzle.Dominant);
			}
			else 
			{
				if(dog2.tail.Dominant) 
					new_muzzle = new Muzzle(dog2.muzzle.Type_muzzle, dog2.muzzle.Dominant);
				else 
				{
					if(RandomBool(rand.Next(0,2)))
						new_muzzle = new Muzzle(dog1.muzzle.Type_muzzle, dog1.muzzle.Dominant);
					else
						new_muzzle = new Muzzle(dog2.muzzle.Type_muzzle, dog2.muzzle.Dominant);
				}
			}
			
			// выберем форму ушей
			Ears new_ears;
			
			if(dog1.ears.Dominant)
			{
				if(dog2.ears.Dominant) 
				{
					if(RandomBool(rand.Next(0,2)))
						new_ears = new Ears(dog1.ears.Type_ears, dog1.ears.Dominant); 
					else 
						new_ears = new Ears(dog2.ears.Type_ears, dog2.ears.Dominant);
				}
				else 
					new_ears = new Ears(dog1.ears.Type_ears, dog1.ears.Dominant);
			}
			else 
			{
				if(dog2.ears.Dominant) 
					new_ears = new Ears(dog2.ears.Type_ears, dog2.ears.Dominant);
				else 
				{
					if(RandomBool(rand.Next(0,2)))
						new_ears = new Ears(dog1.ears.Type_ears, dog1.ears.Dominant);
					else
						new_ears = new Ears(dog2.ears.Type_ears, dog2.ears.Dominant);
				}
			}
			
			return new Dog(new_eyes, new_hair, new Tail(new_tail.Type_tail, new_tail.Dominant), new Muzzle(new_muzzle.Type_muzzle, new_muzzle.Dominant), new Ears(new_ears.Type_ears, new_ears.Dominant));
		}
	}
	
	class Bird:Creature
	{
		private string name = "bird";
		private Break bird_break;
		private WaterfowlBird waterfowl;
		
		public Bird()
		{
			var rand = new Random(DateTime.Now.Millisecond);
			
			base.motion = new Motion(TypeMotion.fly, RandomBool(rand.Next(0,2)));
			base.cover = new Cover(TypeCover.plumage, RandomBool(rand.Next(0,2)));
			base.food = new Food(TypeFood.omnivore, RandomBool(rand.Next(0,2)));
			base.eyes = new Eyes((ColorEyes)rand.Next(0, ColorEyes.GetNames(typeof(ColorEyes)).Length), RandomBool(rand.Next(0,2)));
			base.hair = new Hair((ColorHair)rand.Next(0, ColorHair.GetNames(typeof(ColorHair)).Length), RandomBool(rand.Next(0,2)));
			// features
			bird_break = new Break((TypeBreak)rand.Next(0, TypeBreak.GetNames(typeof(TypeBreak)).Length), RandomBool(rand.Next(0,2)));
			waterfowl = new WaterfowlBird(RandomBool(rand.Next(0,2)), RandomBool(rand.Next(0,2)));
		}
		
		public Bird(Eyes eyes, Hair hair, Break bird_break, WaterfowlBird waterfowl)
		{
			var rand = new Random(DateTime.Now.Millisecond);
			
			base.motion = new Motion(TypeMotion.fly, RandomBool(rand.Next(0,2)));
			base.cover = new Cover(TypeCover.plumage, RandomBool(rand.Next(0,2)));
			base.food = new Food(TypeFood.omnivore, RandomBool(rand.Next(0,2)));
			//
			base.eyes = new Eyes(eyes.Color_eyes, eyes.Dominant);
			base.hair = new Hair(hair.Color_hair, hair.Dominant);
			this.bird_break = new Break(bird_break.Type_break, bird_break.Dominant);
			this.waterfowl = new WaterfowlBird(waterfowl.IsWaterfowl, waterfowl.Dominant);
		}
		
		public string Name
		{
			get
			{
				return name;
			}
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
			var rand = new Random(DateTime.Now.Millisecond);
			
			// выберем цвет глаз 
			Eyes new_eyes;
			
			if(bird1.eyes.Dominant)
			{
				if(bird2.eyes.Dominant) 
				{
					if(RandomBool(rand.Next(0,2)))
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
					if(RandomBool(rand.Next(0,2)))
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
					if(RandomBool(rand.Next(0,2)))
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
					if(RandomBool(rand.Next(0,2)))
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
					if(RandomBool(rand.Next(0,2)))
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
					if(RandomBool(rand.Next(0,2)))
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
					if(RandomBool(rand.Next(0,2)))
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
					if(RandomBool(rand.Next(0,2)))
						new_waterfowl = new WaterfowlBird(bird1.waterfowl.IsWaterfowl, bird1.waterfowl.Dominant);
					else
						new_waterfowl = new WaterfowlBird(bird2.waterfowl.IsWaterfowl, bird2.waterfowl.Dominant);
				}
			}
			
			return new Bird(new_eyes, new_hair, new Break(new_break.Type_break, new_break.Dominant), new WaterfowlBird(new_waterfowl.IsWaterfowl, new_waterfowl.Dominant));
		}
		
		
	}
	
	class Start
	{
		static void Main(string[] args)
		{	
			Creature c1 = new Creature();
			c1.PrintCreature();
			
			Creature c2 = new Creature();
			c2.PrintCreature();
			
			Creature res = c1 + c2;
			res.PrintCreature();
			
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\nTap to continue...");
			Console.ReadKey(true);
		}
	}
}
