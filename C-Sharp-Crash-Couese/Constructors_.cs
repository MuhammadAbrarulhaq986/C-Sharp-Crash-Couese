using System;
namespace C_Sharp_Crash_Couese
{
    internal class Constructors_
    {
        public void Show()
        {
            /* Constructor = A special method in a class 
             *               Same name as the class name
             *               Can be used to assign arguments to fields when creating an oblject  
            */



            //Human human1 = new Human("Gojo", 25);
            //Human human2 = new Human("Yuji" , 20);

            Car car1 = new Car("Ford", "Mustang", 2022, "Red");
            Car car2 = new Car("Mazda", "RX-8", 2018, "Red");

            car1.Drive();
            car2.Drive();

            /*
            human1.name = "Gojo";
            human1.age = 45;
            //----- When we assign a constructor to a class,
            ------- we don't need to assign the values to the fields like this,
            ------- we can do it in the constructor itself.
            human2.name = "Yuji";
            human2.age = 20;
            */
            /*
            human1.Eat();
            human1.Sleep();
            Console.WriteLine();
            human2.Eat();
            human2.Sleep();
             */

        }
    }
    class Car // This is a class named Car
    {
        String make;
        String model;
        int year;
        String color;
        public Car(String make, String model, int year, String color)// This is a constructor for the Car class
        { 
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public void Drive()// This is a method for the Car class
        {
            //Console.WriteLine("You drive the " + make + " " + model);
            Console.WriteLine($"You drive the {make} {model}");

        }
    }
    /*
    class Human
    {
        public String name;
        public int age;
        public Human(String n, int a) 
        {
            this.name = n;
            this.age = a;

        }
        public void Eat()
        {
            Console.WriteLine(name + " is Eating...");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is Sleep...");
        }

    }
     */
}
