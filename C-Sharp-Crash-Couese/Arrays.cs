using System;
namespace C_Sharp_Crash_Couese
{
    internal class Arrays
    {
        public void Show()
        {
            // Array = A variable that can store multiple values, Fixed size, of the same data type

            String[] cars = new string[3];

            //String[] cars = { "BMW", "Mustang", "Corvatta" };

            cars[0] = "Tesla";
            cars[1] = "BMW";
            cars[2] = "Mustang";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars[1]);
            //Console.WriteLine(cars[2]);
            //Console.WriteLine(cars[3]);
        }
    }
}
