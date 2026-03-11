using System;

namespace C_Sharp_Crash_Couese
{
    internal class MathClass
    {
        public void Show() {

            //double x = 3.14;
            double x = 3.99;
            double y = 5;

            //double a = Math.Pow(x, 3);// x to the power of 2, x is the base and 2 is the exponent
            //double b = Math.Sqrt(x); // square root of x
            //double c = Math.Abs(x); // absolute value of x
            //double d = Math.Round(x); // rounds x to the nearest whole number
            //double e = Math.Ceiling(x); // rounds x up to the nearest whole number
            //double f = Math.Floor(x); // rounds x down to the nearest whole number
            //double g = Math.Max(x, y); // returns the larger of x and y
            double h = Math.Min(x, y); // returns the larger of x and y

            Console.WriteLine(h);
        }

    }
}
