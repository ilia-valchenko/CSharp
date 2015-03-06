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
	public enum TypeRace {euro, china, indian, negroid}; // добавить мешпнцев + потом вычесть из длины массива
	// dog
	public enum TypeTail {bagel, stick, bobtailed};
	public enum TypeMuzzle {acute, shortest, brick};
	public enum TypeEars {value1, value2, value3};
	
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
			              "\nType motion: " + motion.Type_motion + 
			              "\nType cover: " + cover.Type_cover + 
			              "\nType food: " + food.Type_food + 
			              "\nEyes color: " + eyes.Color_eyes + 
			              "\nHair color: " + hair.Color_hair
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
						new_motion = new Motion(creature1.motion.Type_motion, false); // пусть у каждого нового существа все признаки будут рецессивными
					else 
						new_motion = new Motion(creature2.motion.Type_motion, false);
				}
				else // если у воторого существа этот признак рецессивный
					new_motion = new Motion(creature1.motion.Type_motion, false);
			}
			else // если у первого существа этот признак рецессивный
			{
				if(creature2.motion.Dominant) // а у второго - нет
					new_motion = new Motion(creature2.motion.Type_motion, false);
				else // если у обоих существ признаки рецессивные
				{
					if(Tools.RandomBool())
						new_motion = new Motion(creature1.motion.Type_motion, false);
					else
						new_motion = new Motion(creature2.motion.Type_motion, false);
				}
			}
			
			// выберем тип покрова существа
			Cover new_cover;
			
			if(creature1.cover.Dominant)
			{
				if(creature2.cover.Dominant)  
				{
					if(Tools.RandomBool())
						new_cover = new Cover(creature1.cover.Type_cover, false); 
					else 
						new_cover = new Cover(creature2.cover.Type_cover, false);
				}
				else 
					new_cover = new Cover(creature1.cover.Type_cover, false);
			}
			else 
			{
				if(creature2.cover.Dominant) 
					new_cover = new Cover(creature2.cover.Type_cover, false);
				else 
				{
					if(Tools.RandomBool())
						new_cover = new Cover(creature1.cover.Type_cover, false);
					else
						new_cover = new Cover(creature2.cover.Type_cover, false);
				}
			}
			
			// выберем тип питания существа
			Food new_food;
			
			if(creature1.food.Dominant)
			{
				if(creature2.food.Dominant) 
				{
					if(Tools.RandomBool())
						new_food = new Food(creature1.food.Type_food, false); 
					else 
						new_food = new Food(creature2.food.Type_food, false);
				}
				else 
					new_food = new Food(creature1.food.Type_food, false);
			}
			else 
			{
				if(creature2.food.Dominant) 
					new_food = new Food(creature2.food.Type_food, false);
				else 
				{
					if(Tools.RandomBool())
						new_food = new Food(creature1.food.Type_food, false);
					else
						new_food = new Food(creature2.food.Type_food, false);
				}
			}
			
			// выберем цвет глаз нового существа
			Eyes new_eyes;
			
			if(creature1.eyes.Dominant)
			{
				if(creature2.eyes.Dominant) 
				{
					if(Tools.RandomBool())
						new_eyes = new Eyes(creature1.eyes.Color_eyes, false); 
					else 
						new_eyes = new Eyes(creature2.eyes.Color_eyes, false);
				}
				else 
					new_eyes = new Eyes(creature1.eyes.Color_eyes, false);
			}
			else 
			{
				if(creature2.eyes.Dominant) 
					new_eyes = new Eyes(creature2.eyes.Color_eyes, false);
				else 
				{
					if(Tools.RandomBool())
						new_eyes = new Eyes(creature1.eyes.Color_eyes, false);
					else
						new_eyes = new Eyes(creature2.eyes.Color_eyes, false);
				}
			}
			
			// выберем цвет волос/шерсти/перьев
			Hair new_hair;
			
			if(creature1.hair.Dominant)
			{
				if(creature2.hair.Dominant) 
				{
					if(Tools.RandomBool())
						new_hair = new Hair(creature1.hair.Color_hair, false); 
					else 
						new_hair = new Hair(creature2.hair.Color_hair, false);
				}
				else 
					new_hair = new Hair(creature1.hair.Color_hair, false);
			}
			else 
			{
				if(creature2.hair.Dominant) 
					new_hair = new Hair(creature2.hair.Color_hair, false);
				else 
				{
					if(Tools.RandomBool())
						new_hair = new Hair(creature1.hair.Color_hair, false);
					else
						new_hair = new Hair(creature2.hair.Color_hair, false);
				}
			}
			
			return new Creature(new_name, new_sex, new_motion, new_cover, new_food, new_eyes, new_hair);
		}
	}
	
	class Human:Creature
	{
		private string name = "human"; // использовать новое ключевое слово
		private TypeRace race;
		
		/*public Human(string name, TypeSex sex, TypeRace race, Eyes eyes, Hair hair, Motion motion, Cover cover, Food food)
		{
			base.name = name;
			base.sex = sex;
			this.race = (TypeRace)Tools.RandomNumber(TypeRace.GetNames(typeof(TypeRace)).Length);
			base.eyes = eyes;
			base.hair = hair;
			base.motion = motion;
			base.cover = cover;
			base.food = food;
		}*/
		
		public Human()
		{
			base.motion = new Motion(TypeMotion.foot, true);
			base.cover = new Cover(TypeCover.leather, true);
			base.food = new Food(TypeFood.omnivore, true);
			// features
			race = (TypeRace)Tools.RandomNumber(TypeRace.GetNames(typeof(TypeRace)).Length);
		}
		
		public override void PrintCreature()
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
			                  "\nRace: " + race +
			                  "\nEyes color: " + eyes.Color_eyes + 
			                  "\nHair color: " + hair.Color_hair +
 			                  "\nType motion: " + motion.Type_motion + 
			                  "\nType cover: " + cover.Type_cover + 
			                  "\nType food: " + food.Type_food 
			                  );
			
		}
		
		public static Human operator + (Human human1, Human human2)
		{ 	
			// выберем пол существа
			TypeSex new_sex = TypeSex.male;
			
			if(Tools.RandomBool())
				new_sex = TypeSex.male;
			else
				new_sex = TypeSex.female;
			
			// выберем цвет глаз нового существа
			Eyes new_eyes;
			
			if(creature1.eyes.Dominant)
			{
				if(creature2.eyes.Dominant) 
				{
					if(Tools.RandomBool())
						new_eyes = new Eyes(creature1.eyes.Color_eyes, false); 
					else 
						new_eyes = new Eyes(creature2.eyes.Color_eyes, false);
				}
				else 
					new_eyes = new Eyes(creature1.eyes.Color_eyes, false);
			}
			else 
			{
				if(creature2.eyes.Dominant) 
					new_eyes = new Eyes(creature2.eyes.Color_eyes, false);
				else 
				{
					if(Tools.RandomBool())
						new_eyes = new Eyes(creature1.eyes.Color_eyes, false);
					else
						new_eyes = new Eyes(creature2.eyes.Color_eyes, false);
				}
			}
			
			// выберем цвет волос/шерсти/перьев
			Hair new_hair;
			
			if(creature1.hair.Dominant)
			{
				if(creature2.hair.Dominant) 
				{
					if(Tools.RandomBool())
						new_hair = new Hair(creature1.hair.Color_hair, false); 
					else 
						new_hair = new Hair(creature2.hair.Color_hair, false);
				}
				else 
					new_hair = new Hair(creature1.hair.Color_hair, false);
			}
			else 
			{
				if(creature2.hair.Dominant) 
					new_hair = new Hair(creature2.hair.Color_hair, false);
				else 
				{
					if(Tools.RandomBool())
						new_hair = new Hair(creature1.hair.Color_hair, false);
					else
						new_hair = new Hair(creature2.hair.Color_hair, false);
				}
			}
			
			//получим новую расу
			TypeRace new_race;
			
			if(human1.race == TypeRace.euro)
			{
				switch(human2.race)
				{
					case TypeRace.china:
						new_race = TypeRace.
				}
			}
			
			return new Creature(new_name, new_sex, new_motion, new_cover, new_food, new_eyes, new_hair);
		}
	}
	
	class Dog:Creature
	{
		private string name = "dog";
		private TypeTail tail;
		private TypeMuzzle muzzle;
		private TypeEars ears;
		
		public Dog()
		{
			base.motion = new Motion(TypeMotion.foot, false);
			base.cover = new Cover(TypeCover.leather, false);
			base.food = new Food(TypeFood.omnivore, true);
			// features
			tail = (TypeTail)Tools.RandomNumber(TypeTail.GetNames(typeof(TypeTail)).Length);
			muzzle = (TypeMuzzle)Tools.RandomNumber(TypeMuzzle.GetNames(typeof(TypeMuzzle)).Length);
			ears = (TypeEars)Tools.RandomNumber(TypeEars.GetNames(typeof(TypeEars)).Length);
		}
		
		public override void PrintCreature()
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
							  "\nType tail: " + tail +
							  "\nType muzzle: " + muzzle + 
							  "\nType ears: " + ears +
			                  "\nEyes color: " + eyes.Color_eyes + 
			                  "\nHair color: " + hair.Color_hair +
 			                  "\nType motion: " + motion.Type_motion + 
			                  "\nType cover: " + cover.Type_cover + 
			                  "\nType food: " + food.Type_food 
			                  );
		}
	}
	
	class Start
	{
		static void Main(string[] args)
		{	
			Creature cr1 = new Creature("human", TypeSex.male, new Motion(TypeMotion.foot, true), new Cover(TypeCover.plumage, false), new Food(TypeFood.omnivore, true), new Eyes(ColorEyes.green, true), new Hair(ColorHair.golden, true));
			Creature cr2 = new Creature("shark", TypeSex.female, new Motion(TypeMotion.swim, false), new Cover(TypeCover.scales, true), new Food(TypeFood.herbivore, true), new Eyes(ColorEyes.grey, false), new Hair(ColorHair.black, false));
			
			Console.WriteLine("\nAFTER MUTATION:\n");
			Creature res;
			res = cr1 + cr2;
			res.PrintCreature();
				
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\nTap to continue...");
			Console.ReadKey(true);
		}
	}
}
