public struct Muzzle
	{
		private TypeMuzzle type_muzzle;
		private bool dominant;
		
		public Muzzle(TypeMuzzle type_muzzle, bool dominant)
		{
			this.type_muzzle = type_muzzle;
			this.dominant = dominant;
		}
		
		public TypeMuzzle Type_muzzle
		{
			get
			{
				return type_muzzle;
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