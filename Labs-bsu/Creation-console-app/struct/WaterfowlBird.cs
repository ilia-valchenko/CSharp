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