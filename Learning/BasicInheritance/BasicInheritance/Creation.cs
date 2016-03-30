using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Creation
    {
        private int Environment { get; set; }
        private int Food { get; set; }
        private int Limbs { get; set; }

        public Creation(TypeOfEnvironment env, TypeOfFood fd, TypeOfLimbs lb)
        {
            Environment = (int)env;
            Food = (int)fd;
            Limbs = (int)lb;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Hello! Your creature lives in {0} and it's {1}.\nAmazing! How did you made it go on {2}?", (TypeOfEnvironment)Environment, (TypeOfFood)Food, (TypeOfLimbs)Limbs);
        }
    }
}

public enum TypeOfEnvironment { ocean, earth, air };
public enum TypeOfFood { herbivorous, carnivorous, omnivorous };
public enum TypeOfLimbs { foot, fin, wing };
