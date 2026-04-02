using System;
namespace C_Sharp_Crash_Couese
{
    internal class Inheritance
    {
        public void Show() 
        {
            /* Inheritance = One or more child classes reciving fields, methods, etc, from a common parent */
       
            Car1 car = new Car1();
        
            Bicycle bicycle = new Bicycle();
        
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();
            
            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.go();
            
            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();
        
        }
    }
    class Vehicle 
    {
        public int speed = 0;
        public void go() // Method
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car1 : Vehicle 
    {
        public int wheels = 4;
    }
    class Bicycle : Vehicle 
    {
        public int wheels = 2;
    }
    class Boat : Vehicle 
    {
        public int wheels = 0;
    }

}
