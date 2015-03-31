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