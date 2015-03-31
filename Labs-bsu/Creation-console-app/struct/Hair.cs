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