using System;

namespace C_Sharp_Crash_Couese
{
    internal class Interfaces
    {
        public void Show()
        {
            /* Interfaces = Defines a "contract" that all the classes inheriting from should follow
                    
                            An Interface declares "What a class should have "
                            An Inheriting class defines "how it should do it"
                            
                            Benefit = security + multiple inheritance + "Plug-and-play"
             */

            Rabbit rabbit = new Rabbit();
            //rabbit.Flee();
        
            Hawk hawk = new Hawk();
            //hawk.Hunt();
     
            Fish fish = new Fish();
            fish.Flee();
            fish.Hunt();
        }
    }
    interface IPrey
    {
        void Flee();// Declaring it but not implementing it.
    }
    interface IPredator
    {
        void Hunt();// Declaring it but not implementing it.

    }
    class Rabbit : IPrey
    {
        public void Flee() 
        {
            Console.WriteLine("The Rabbit runs away!");   
        }
    }
    class Hawk : IPredator 
    {
        public void Hunt()
        {
            Console.WriteLine("The Hawk is searching for food!");
        }
    }
    class Fish
    {
        public void Flee()
        {
            Console.WriteLine("The Fish swims away!");
        }
        public void Hunt() 
        {
            Console.WriteLine("The Fish is searching for smaller fish!");
        }
    }

}
