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
	public enum TypeSex {male, female};
	// human
	public enum TypeRace {europid, negroid, indigenous, asian, mestizo, mulatto, zambo}; 
	// dog
	public enum TypeTail {bagel, saber, hook, rod, sickle, ring, bobtailed}; // бубликом, саблевидный, крючком, прутом, серпом, кольцевидный, бубликом, куцый
	public enum TypeMuzzle {gaunt, brief, pointed, blunt}; // длинная, короткая, заостренная, тупая
	public enum TypeEars {prick_ears, hanging_ears, semi_prick_ears}; // стоячие уши, висячие уши, полустоячие уши
	
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
		protected TypeSex sex;
		protected Motion motion;
		protected Cover cover;
		protected Food food;
		protected Eyes eyes;
		protected Hair hair;
		
		public Creature(string name, TypeSex sex, Motion motion, Cover cover, Food food, Eyes eyes, Hair hair)
		{	
			this.name = name;
			this.sex = sex;
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
			
			// choose the sex
			if(Tools.RandomBool())
				sex = TypeSex.male;
			else
				sex = TypeSex.female;
			
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
			this.sex = creature.sex;
			this.motion = creature.motion;
			this.cover = creature.cover;
			this.food = creature.food;
			this.eyes = creature.eyes;
			this.hair = creature.hair;
		}
		
		public virtual void PrintCreature()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("PRINT YOUR CREATURE:");
			Console.ResetColor();
			Console.Write("\nName: ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(name);
			Console.ResetColor();
			Console.WriteLine(
			              "\nSex: " + sex +
			              "\nType motion: " + motion.Type_motion + " (" + motion.Dominant + ")" +   
			              "\nType cover: " + cover.Type_cover + " (" + cover.Dominant + ")" + 
			              "\nType food: " + food.Type_food + " (" + food.Dominant + ")" + 
			              "\nEyes color: " + eyes.Color_eyes + " (" + eyes.Dominant + ")" +
			              "\nHair color: " + hair.Color_hair + " (" + hair.Dominant + ")"
			             );
		}
		
		public static Creature operator + (Creature creature1, Creature creature2)
		{
			// создадим новое имя существу
			string new_name = creature1.name.Substring(creature1.name.Length/2) + creature2.name.Substring(creature2.name.Length/2);
			
			// выберем пол существа
			TypeSex new_sex = TypeSex.male;
			
			if(Tools.RandomBool())
				new_sex = TypeSex.male;
			else
				new_sex = TypeSex.female;
			
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
			
			return new Creature(new_name, new_sex, new_motion, new_cover, new_food, new_eyes, new_hair);
		}
	}
	
	class Human:Creature
	{
		private string name = "human"; // hide
		private TypeRace race;
		
		public Human(TypeSex sex, TypeRace race, Eyes eyes, Hair hair)
		{
			base.sex = sex;
			this.race = race;
			base.eyes = eyes;
			base.hair = hair;
			base.motion = new Motion((TypeMotion)Tools.RandomNumber(TypeMotion.GetNames(typeof(TypeMotion)).Length), Tools.RandomBool());
			base.cover = new Cover((TypeCover)Tools.RandomNumber(TypeCover.GetNames(typeof(TypeCover)).Length), Tools.RandomBool());
			base.food = new Food((TypeFood)Tools.RandomNumber(TypeFood.GetNames(typeof(TypeFood)).Length), Tools.RandomBool());
		}
		
		public Human()
		{
			if(Tools.RandomBool())
				base.sex = TypeSex.male;
			else
				base.sex = TypeSex.female;
			
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
			Console.WriteLine("PRINT YOUR HUMAN:");
			Console.ResetColor();
			Console.Write("\nName: ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(name);
			Console.ResetColor();
			Console.WriteLine( 
			                  "\nSex: " + sex +
			                  "\nRace: " + race + 
			                  "\nEyes color: " + eyes.Color_eyes + " (" + eyes.Dominant + ")" + 
			                  "\nHair color: " + hair.Color_hair + " (" + hair.Dominant + ")" 
			                  );
			
		}
		
		public static Human operator + (Human human1, Human human2)
		{ 	
			// выберем пол 
			TypeSex new_sex;
			
			if(Tools.RandomBool())
				new_sex = TypeSex.male;
			else
				new_sex = TypeSex.female;
			
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
			
			return new Human(new_sex, new_race, new_eyes, new_hair);
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
			if(Tools.RandomBool())
				base.sex = TypeSex.male;
			else
				base.sex = TypeSex.female;
			
			base.motion = new Motion(TypeMotion.foot, Tools.RandomBool());
			base.cover = new Cover(TypeCover.wool, Tools.RandomBool());
			base.food = new Food(TypeFood.omnivore, Tools.RandomBool());
			base.eyes = new Eyes((ColorEyes)Tools.RandomNumber(ColorEyes.GetNames(typeof(ColorEyes)).Length), Tools.RandomBool());
			base.hair = new Hair((ColorHair)Tools.RandomNumber(ColorHair.GetNames(typeof(ColorHair)).Length), Tools.RandomBool());
			
			// features
			tail = new Tail((TypeTail)Tools.RandomNumber(TypeTail.GetNames(typeof(TypeTail)).Length), Tools.RandomBool());
			muzzle = new Muzzle((TypeMuzzle)Tools.RandomNumber(TypeMuzzle.GetNames(typeof(TypeMuzzle)).Length), Tools.RandomBool());
			ears = new Ears((TypeEars)Tools.RandomNumber(TypeEars.GetNames(typeof(TypeEars)).Length), Tools.RandomBool());
		}
		
		public Dog(TypeSex sex, Eyes eyes, Hair hair, Tail tail, Muzzle muzzle, Ears ears)
		{
			base.sex = sex;
			base.eyes = new Eyes(eyes.Color_eyes, eyes.Dominant);
			base.hair = new Hair(hair.Color_hair, hair.Dominant);
			this.tail = new Tail(tail.Type_tail, tail.Dominant);
			this.muzzle = new Muzzle(muzzle.Type_muzzle, muzzle.Dominant);
			this.ears = new Ears(ears.Type_ears, ears.Dominant);
			// standard
			base.motion = new Motion(TypeMotion.foot, Tools.RandomBool());
			base.cover = new Cover(TypeCover.wool, Tools.RandomBool());
			base.food = new Food(TypeFood.omnivore, Tools.RandomBool());
		}
		
		public override void PrintCreature()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("PRINT YOUR DOG:");
			Console.ResetColor();
			Console.Write("\nName: ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(name);
			Console.ResetColor();
			Console.WriteLine(
			                  "\nSex: " + sex + 
							  "\nType tail: " + tail +
							  "\nType muzzle: " + muzzle + 
							  "\nType ears: " + ears +
			                  "\nEyes color: " + eyes.Color_eyes + " (" + eyes.Dominant + ")" + 
			                  "\nHair color: " + hair.Color_hair + " (" + hair.Dominant + ")"
			                  );
		}
		
		public static Dog operator + (Dog dog1, Dog dog2)
		{ 
			TypeSex new_sex;
			if(Tools.RandomBool())
				new_sex = TypeSex.male;
			else
				new_sex = TypeSex.female;
			
			// выберем цвет глаз 
			Eyes new_eyes;
			
			if(dog1.eyes.Dominant)
			{
				if(dog2.eyes.Dominant) 
				{
					if(Tools.RandomBool())
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
					if(Tools.RandomBool())
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
					if(Tools.RandomBool())
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
					if(Tools.RandomBool())
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
					if(Tools.RandomBool())
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
					if(Tools.RandomBool())
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
					if(Tools.RandomBool())
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
					if(Tools.RandomBool())
						new_muzzle = new Muzzle(dog1.muzzle.Type_muzzle, dog1.muzzle.Dominant);
					else
						new_muzzle = new Muzzle(dog2.muzzle.Type_muzzle, dog2.muzzle.Dominant);
				}
			}
			
			return new Dog(new_sex, new_eyes, new_hair, new Tail(TypeTail.hook, true), new Muzzle(TypeMuzzle.pointed, false), new Ears(TypeEars.hanging_ears, true));
		}
	}
	
	class Start
	{
		static void Main(string[] args)
		{	
			
				
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\nTap to continue...");
			Console.ReadKey(true);
		}
	}
}
