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