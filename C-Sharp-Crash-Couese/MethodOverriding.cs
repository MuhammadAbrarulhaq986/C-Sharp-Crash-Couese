using System;
namespace C_Sharp_Crash_Couese
{
    internal class MethodOverriding
    {
        public void Show()
        {
            /* 
            Method overriding = provides a new version of a method inherited from a parent class
                                inherited method must be: Abstract, Virtual, or Already  Override 
                                Used with ToString(), Polymorphism and Abstract classes
            */
            Dog dog = new Dog(); // This is a Dog object 

            Cat cat = new Cat(); // This is a Cat object
        
            dog.Speak();
            cat.Speak();
        }
        class Animal 
        {
            public virtual void Speak() 
            {
                Console.WriteLine("The animal goes *Burr*");
            }    
        }
        class Dog : Animal 
        {
            public override void Speak()
            {
                Console.WriteLine("The Dog goes *Woof*");
            }
        }   
        class Cat : Animal 
        {
            public override void Speak()
            {
                Console.WriteLine("The Cat goes *Meow*");
            }
        }   
    }
}

