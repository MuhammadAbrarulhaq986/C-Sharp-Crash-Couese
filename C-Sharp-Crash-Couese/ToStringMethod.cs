using System;
namespace C_Sharp_Crash_Couese
{
    internal class ToStringMethod
    {
        public void Show()
        {
            /*ToString = Consverts an object to its
             *           string representation so that
             *           it is suitable for display*/
            Car3 car = new Car3("Toyota", "Camry", 2026, "Green");

            Console.WriteLine(car.ToString());//Default implementation of ToString() method
            Console.WriteLine(car);//When we pass an object to Console.WriteLine() method, it automatically calls the ToString() method of that object to get its string representation and then prints it to the console.

        }
    }
    class Car3
    {
        String make;
        String model;
        int year;
        String color;
        public Car3(String make, String model, int year, String color)//Constructor
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            return "This is a " + make + " " + model;
            /*
            String message = "This is a " + make + " " + model;  
            return message;
            return base.ToString();
            */
        }
    }
}
