using System;

namespace C_Sharp_Crash_Couese
{
    internal class ReturnKeyword
    {
        public void Show()
        {
            // Return = returns data back to the place where a method is Invoked (called)

            double x, y;
            double result;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x,y);

            Console.WriteLine(result);
        }

        static double Multiply(double x, double y)
        {
            double z = x * y;
            return z;
        }
    }
}
