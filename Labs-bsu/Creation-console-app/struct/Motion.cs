public struct Motion
	{	
    	private TypeMotion type_motion;
    	private bool dominant;

    	public Motion(TypeMotion type_motion, bool dominant)
	    {
	        this.type_motion = type_motion;
	        this.dominant = dominant;
	    }
    	
    	public TypeMotion Type_motion
    	{
    		set
    		{
    			type_motion = value;
    		}
    		get
    		{
    			return type_motion;
    		}
    	}
    	
    	public bool Dominant
    	{
    		set
    		{
    			dominant = value;
    		}
    		get
    		{
    			return dominant;
    		}
    	}
	}