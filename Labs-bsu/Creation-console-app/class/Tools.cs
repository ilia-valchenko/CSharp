using System;

class Tools
    {
        public static int RandomNumber(int end)
        {
            var rand = new Random();
            return rand.Next(0, end);
        }
        
        public static bool RandomBool()
        {
        	if(RandomNumber(2) == 0)
        		return true;
        	else 
        		return false;
        }
    }
