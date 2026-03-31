using System;
namespace C_Sharp_Crash_Couese
{
    internal class StaticModifier
    {
        class  Car 
        {
            String model;
            public static int numOfCars;
            public Car(String model)
            {
                this.model = model;
                numOfCars++;
            }
            public static void StartRace() 
            {
                Console.WriteLine("The Race has began!!!");
            }
        }
        public void Show()
        {
            /* static = Modifier to declare a static member, 
                           which belong to the class itself rather
                           then to any specific object.
                           Static members can be accessed without 
                           creating an instance of the class.*/

            Car car1 = new Car("RX-8");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lamborgini");

            Console.WriteLine(Car.numOfCars);
            
            //Console.WriteLine(car1.numOfCars);
            //Console.WriteLine(car2.numOfCars);

            Car.StartRace();

        }
    }
}
