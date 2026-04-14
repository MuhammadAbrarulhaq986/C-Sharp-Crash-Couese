using System;
namespace C_Sharp_Crash_Couese
{
    internal class AutoImplementedProperties
    {
        public void Show() 
        {
            /* Auto-Implemented Properties  = shortcut when no additional logic is required in the property
                                              you do not have to define a field for a property,
                                              you only have to write get; and/or set; inside the property */

            Car8 car  = new Car8 ("BMW");
            Console.WriteLine(car.Model);   
        }
    }
    class Car8 
    {
        /*
        String model;
        
        public String Model
        {
            get { return model; }
            set { model = value; }
        }
        */
        public String Model { get; set; }// Auto-Implemented Property
        public Car8(String model) // Constructor
        {
            this.Model = model;
        }
        
    }
}
