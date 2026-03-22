using System;

namespace C_Sharp_Crash_Couese
{
    internal class ForEachLoop
    {
        public void Show()
        {
            // ForEach loop = A simpler way to iterate over an array, but Its less flexible than a for loop

            String[] cars = { "BMW", "Mustang", "Corvette" };

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);   
            //}

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
