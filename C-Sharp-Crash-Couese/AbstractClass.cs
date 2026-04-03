using System;
namespace C_Sharp_Crash_Couese
{
    internal class AbstractClass
    {
        public void Show()
        {
            //Abstract Class = modifier that incicates missing components or Incomplete Implementation. 
            Car2 car = new Car2();
            Bicycle2 bicycle = new Bicycle2();  
            Boat2 boat = new Boat2();

           //  Vehicle2 vehicle = new Vehicle2();  


        }
    }
    abstract class Vehicle2 
    {
        public int speed = 0;
        public void go() // Method
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
        class Car2 : Vehicle2 
        {
            public int wheels = 4;
            int maxspeed = 500;
        }
        class Bicycle2 : Vehicle2 
        {
            public int wheels = 2;
            int maxspeed = 50;
        }
        class Boat2 : Vehicle2
        {
            public int wheels = 0;
            int maxspeed = 100;
        }
}


