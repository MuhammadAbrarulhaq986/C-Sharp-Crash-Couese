using System;

namespace C_Sharp_Crash_Couese
{
    internal class GettersSetters
    {
        public void Show()    
        {
            /* Getters & Setters = add security to fields bt encapsulation
                                   Ther're accessors found within properties
            
            Properties = Combine aspects of both fields and methods ( Share name with a field)
            Get accessor = used to return the property value
            Get accessor = used to assign a new value
            value keyword = defines the value being assigned by the set (parameter) */

            Car9 car1 = new Car9(400);

            car1.Speed = 1000000000;

            Console.WriteLine(car1.Speed);
        }
    }
    class Car9
    {
        private int speed;

        public Car9(int speed) 
        {
            Speed = speed;
        }
        public int Speed 
        {
            get { return speed; } // Read only
            set // Write only
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                speed = value; 
                }
            }
        }
    }
}
