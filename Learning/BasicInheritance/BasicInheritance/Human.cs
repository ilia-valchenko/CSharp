using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Human : Creation
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private int Sex { get; set; }

        // default constructor
        public Human() : base(TypeOfEnvironment.earth, TypeOfFood.omnivorous, TypeOfLimbs.foot) { }

        public Human(string name, int age, Sex sex) : base(TypeOfEnvironment.earth, TypeOfFood.omnivorous, TypeOfLimbs.foot)
        {
            Name = name;
            Age = age;
            Sex = (int)sex;
        }

        public void PrintInfo()
        {
            if(Sex == 0) // male
            {
                if (Age < 5)
                    Console.WriteLine(" - Look at this cute baby! It's a boy! How did you say your name was?\n - {0}. His name is {0}.", Name);

                if (Age < 15 && Age > 5)
                    Console.WriteLine(" - Ho-ho! You are disobedient boy! What is your name?\n - My name is captain {0}.", Name);

                if (Age < 30 && Age > 15)
                    Console.WriteLine("This is {0} and he was {1}. It's enough.", Name, Age);

                if (Age < 50 && Age > 30)
                    Console.WriteLine("Do you see him? It's {0}! He was famous a long time ago. Now, perhaps, he was about {1}.", Name, Age);

                if (Age < 100 && Age > 50)
                    Console.WriteLine("I don't remember the name of this old men. {0} or Simon. It's doesn't matter.", Name);

            } else // female
            {
                if(Age < 5)
                    Console.WriteLine("{0}! Yes, it will be your name! The great future expect you!", Name);

                if (Age < 15 && Age > 5)
                    Console.WriteLine(" - What is your name young princess?\n - {0}. Nice to meet you.", Name);

                if (Age < 30 && Age > 15)
                    Console.WriteLine(" - Heey, pretty women! Can you tell us your name?\n - Hi, I'm {0}.", Name);

                if (Age < 50 && Age > 30)
                    Console.WriteLine("Seems like {0} in {1}.", Name, Age);

                if (Age < 100 && Age > 50)
                    Console.WriteLine("She's name is {0} and she is always young!", Name);
            }
        }
    }

    public enum Sex { male, female };
}
