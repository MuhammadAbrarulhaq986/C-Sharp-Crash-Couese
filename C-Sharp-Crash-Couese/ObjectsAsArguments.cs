using System;
namespace C_Sharp_Crash_Couese
{
    internal class ObjectsAsArguments
    {
        public void Show()
        {
            Car4 car1 = new Car4("Mustang", "Red");

            Car4 car2 = Copy(car1);
        
            //ChangeColor(car1, "Blue"); // Pass the object as an argument to the method

            //Console.WriteLine($"{car1.model}, {car1.color}");

            Console.WriteLine($"{car2.model}, {car2.color}");
        }
        public static Car4 Copy(Car4 car) 
        {
            return new Car4(car.model, car.color); // Create a new object with the same properties
        }

        /* This is a method that takes an object as an argument and changes its color
        public static void ChangeColor(Car4 car, String color) 
        {
        car.color = color;
        }
         */
    }
    class Car4
    {
        public String model;
        public String color;

        public Car4(String model, string color)// constructor
        {
            this.model = model; // Filed
            this.color = color;
        }
    }
}
