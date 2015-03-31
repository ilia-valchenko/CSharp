using System;

class Dog:Creature
	{
		private Tail tail;
		private Muzzle muzzle;
		private Ears ears;
		
		public Dog()
		{	
			base.name = "dog";
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
		
		public Dog(Eyes eyes, Hair hair, Tail tail, Muzzle muzzle, Ears ears)
		{
			base.name = "dog";	
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

        public Tail Tail
        {
            get
            {
                return tail;
            }
        }

        public Muzzle Muzzle
        {
            get
            {
                return muzzle;
            }
        }

        public Ears Ears
        {
            get
            {
                return ears;
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
			                  "\nWool color: " + hair.Color_hair + " (" + hair.Dominant + ")"
			                  );
		}
		
		public static Dog operator + (Dog dog1, Dog dog2)
		{ 	
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
			
			// выберем форму ушей
			Ears new_ears;
			
			if(dog1.ears.Dominant)
			{
				if(dog2.ears.Dominant) 
				{
					if(Tools.RandomBool())
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
					if(Tools.RandomBool())
						new_ears = new Ears(dog1.ears.Type_ears, dog1.ears.Dominant);
					else
						new_ears = new Ears(dog2.ears.Type_ears, dog2.ears.Dominant);
				}
			}
			
			return new Dog(new_eyes, new_hair, new Tail(new_tail.Type_tail, new_tail.Dominant), new Muzzle(new_muzzle.Type_muzzle, new_muzzle.Dominant), new Ears(new_ears.Type_ears, new_ears.Dominant));
		}
		
		public static implicit operator Human(Dog dog)
		{	
			return new Human(
							(TypeRace)Tools.RandomNumber(TypeRace.GetNames(typeof(TypeRace)).Length),
						   new Eyes(dog.Eyes.Color_eyes, dog.Eyes.Dominant), 
			               new Hair(dog.Hair.Color_hair, dog.Hair.Dominant)
						   );
		}
		
		public static implicit operator Bird(Dog dog)
		{	
			return new Bird(
						   new Eyes(dog.Eyes.Color_eyes, dog.Eyes.Dominant), 
			               new Hair(dog.Hair.Color_hair, dog.Hair.Dominant),
			               new Break((TypeBreak)Tools.RandomNumber(TypeBreak.GetNames(typeof(TypeBreak)).Length), Tools.RandomBool()),
			               new WaterfowlBird(Tools.RandomBool(), Tools.RandomBool())
						   );
		}
	}
