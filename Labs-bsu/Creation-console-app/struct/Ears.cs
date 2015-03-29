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