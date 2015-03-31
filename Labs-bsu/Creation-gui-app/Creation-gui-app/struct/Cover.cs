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