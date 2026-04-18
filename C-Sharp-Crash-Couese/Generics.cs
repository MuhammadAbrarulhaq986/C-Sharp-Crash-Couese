using System;
namespace C_Sharp_Crash_Couese
{
    internal class Generics
    {
        public void Show() 
        {
            /* Generics = "Not specific to a particular data type"
                           Add <T> to: Classes, Methods, Fields, etc.
                           Allows for code reusability for different types */

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            DisplayElements(intArray);
            DisplayElements(doubleArray);
            DisplayElements(stringArray);
        }
        public static void DisplayElements<Thing>(Thing[] array) 
        {
            foreach (Thing item in array)
            {
                Console.Write(item + " ");
            }
                Console.WriteLine();
        }
        /*
        public static void DisplayElements(int[] array) 
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
                Console.WriteLine();
        }
        
        public static void DisplayElements(double[] array) 
        {
            foreach (double item in array)
            {
                Console.Write(item + " ");
            }
                Console.WriteLine();
        }
        public static void DisplayElements(String[] array) 
        {
            foreach (String item in array)
            {
                Console.Write(item + " ");
            }
                Console.WriteLine();
        }
         */
    }
}
