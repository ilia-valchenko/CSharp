using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Car : Radio
    {
        private const double maxSpeed = 100.00;
        private bool carIsDead;
        public bool CarIsDead { get; }
        public double CurrentSpeed { get; set; }
        public string PetName { get; set; }

        // car have the radio
        Radio musicBox = new Radio();

        public Car() { }
        public Car(string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }

        public void CrankTunes(bool state)
        {
            musicBox.TurnOn(state);
        }

        public void Accelerate(double delta)
        {
            if (CarIsDead)
                Console.WriteLine("Car is dead.");
            else
            {
                CurrentSpeed += delta;

                if(CurrentSpeed > maxSpeed)
                {
                    // Console.WriteLine("{0} has overheated.", PetName);
                    CurrentSpeed = 0;
                    carIsDead = true;
                    // generate exeption 
                    throw new Exception(string.Format("{0} has overheated!", PetName));
                } else
                {
                    Console.WriteLine("Current speed is {0}.", CurrentSpeed);
                }
            }
        }
    }
}
