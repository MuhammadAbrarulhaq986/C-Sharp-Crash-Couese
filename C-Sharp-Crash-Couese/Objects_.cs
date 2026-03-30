using System;
using System.IO.Pipes;
namespace C_Sharp_Crash_Couese
{
    internal class Objects_
    {
        public  void SHow()
        {
        /*
        Objects = An Instance of a class
                  A class can be used as a blueprint to create objects (OOP)
                  Objects can have fields & methods (Characteristics & actions)
        */ 

            Humen humen1 = new Humen();
            Humen humen2 = new Humen();

            humen1.name = "Gojo";
            humen1.age = 45;

            humen2.name = "Yuji";
            humen2.age = 20;


            humen1.Eat();
            humen1.Sleep();
            Console.WriteLine();
            humen2.Eat();
            humen2.Sleep();

        }
    }
    class Humen 
    {
        public String name;
        public int age;

        public void Eat() {
        Console.WriteLine(name +  " is Eating...");
        }
        public void Sleep() {
        Console.WriteLine(name +  " is Sleep...");
        }
    }
}
