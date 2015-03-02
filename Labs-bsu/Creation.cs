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
	public enum TypeCover {leather, wool, scales};
	public enum TypeFood {carnivore, herbivore, omnivore};
	
	public struct Motion
	{	
    	private TypeMotion type_motion;
    	private bool dominant;

    	public Motion(TypeMotion type_motion, bool dominant)
	    {
	        this.type_motion = type_motion;
	        this.dominant = dominant;
	    }
    	
    	public TypeMotion Type_motion()
    	{
    		//only for read
    		get
    		{
    			return type_motion;
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
		
		public TypeCover Type_Cover()
		{
			get
			{
				return type_cover;
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
		
		public TypeFood Type_food()
		{
			get
			{
				return type_food;
			}
		}
	}
	
	class Creature // private default
	{
		protected string name;
		protected Motion motion;
		protected Cover cover;
		protected Food food;
		
		public Creature(string name, Motion motion, Cover cover, Food food)
		{
			motion = new Motion();
			cover = new Cover();
			food = new Food();
			
			this.name = name;
			this.motion = motion;
			this.cover = cover;
			this.food = food;
		}
		
		public void PrintCreature()
		{
			Console.WriteLine("PRINT YOUR CREATURE:\nName: " + name + "\nType motion: "); 
			Console.Write(motion.Type_motion);
			Console.WriteLine("\nType cover: ");
			Console.Write(cover.Type_Cover);
		}
	}
	
	class Start
	{
		static void Main(string[] args)
		{
			Creature ob = new Creature("Fenix", new Motion(TypeMotion.foot, false), new Cover(TypeCover.wool, true), new Food(TypeFood.carnivore, true));
			ob.PrintCreature();
			
			Console.WriteLine("\nTap to continue...");
			Console.ReadKey(true);
		}
	}
}