using System;

namespace C_Sharp_Crash_Couese
{
    internal class HypotenuseCalculator
    {
        public void Show()
        {
            Console.WriteLine("Enter side A:");
            double a  = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter side B:");
            double b  = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The Hypotenuse is: " + c);

        }
    }
}
