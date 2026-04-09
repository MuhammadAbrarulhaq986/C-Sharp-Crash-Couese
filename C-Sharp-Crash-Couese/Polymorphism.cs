using System;
namespace C_Sharp_Crash_Couese
{
    internal class Polymorphism
    {
        public void Show()
        {
            /* Polymorphism = Greek word means to "Have many froms"
                              Ojects can be identified by more then one type 
                              Ex: A Dog is also : Canice , Animal, Organism
            */

            Car5 car = new Car5();
            Bycycle5 bycycle = new Bycycle5();
            Boat5 boat = new Boat5();

            Vehicle5[] vechicles = { car, bycycle, boat };

            foreach (Vehicle5 vehicle in vechicles)
            {
                vehicle.Go();
            }
        }
    }
    class Vehicle5
    {
        public virtual void Go() 
        {
        }
    }
    class Car5 : Vehicle5
    {
        public override void  Go()
        {
            Console.WriteLine("The Car is Moving!");
        }
    }
    class Bycycle5 : Vehicle5
    {
        public override void Go()
        {
            Console.WriteLine("The Bycycle is Moving!");
        }
    }
    class Boat5 : Vehicle5
    {
        public override void Go()
        {
            Console.WriteLine("The Boat is Moving!");
        }
    }
}
