public struct Break
	{
		private TypeBreak type_break;
		private bool dominant;
		
		public Break(TypeBreak type_break, bool dominant)
		{
			this.type_break = type_break;
			this.dominant = dominant;
		}
		
		public TypeBreak Type_break
		{
			get
			{
				return type_break;
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