using System;
using System.CodeDom.Compiler;

namespace C_Sharp_Crash_Couese
{
    internal class LogicalOperators
    {
        public void Show()
        {
            // Logical operators = Can be used to check of more then 1 condition is true /false
            // && = AND operator (both conditions must be true)
            // || = OR operator (one of the conditions must be true)

            Console.WriteLine("Whats the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());
          
            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's worm outside!");
            }
            else if (temp <= -50 || temp >= 50 )
            {
                Console.WriteLine("DON'T GO OUTSIDE!");
            }
        }   
    }
}
