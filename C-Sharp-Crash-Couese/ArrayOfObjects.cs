using System;
namespace C_Sharp_Crash_Couese
{
    internal class ArrayOfObjects
    {
        public void Show()
        {
            /*
            Car3[] garage = new Car3[3];

            Car3 car1 = new Car3("Toyota");
            Car3 car2 = new Car3("Mazda");
            Car3 car3 = new Car3("Lambo");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;

            All of this can be done in one line as shown below,
            which is more efficient and cleaner.
             */

            Car3[] garage = { new Car3("Toyota"), new Car3("Mazda"), new Car3("Lambo") };
        
            foreach (Car3 car in garage) 
            {
                Console.WriteLine(car.model);
            }

            /*
            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);
            */
        }
        class Car3
        {
            public String model;

            public Car3(String model)// constructor
            {
                this.model = model; // Filed
            }
        }
    }   
}
