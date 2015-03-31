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