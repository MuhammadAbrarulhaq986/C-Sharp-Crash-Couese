using System;
namespace C_Sharp_Crash_Couese
{
    internal class MethodOverloading
    {
        public void Show()
        {
            /*
             Method overloading = methods share same name, but different parameters
                                  name + parameters = signature
                                  methods must have a unique signature */
            double total;

            total = Multiply(2, 3, 4);

            Console.WriteLine(total);
            Console.ReadLine();
        }
        /* 
          Move this OUTSIDE of the Show() method
          This is now a class member (static method)
        */
        static double Multiply(double a, double b)
        {
                return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
                return a * b * c;
        }

    }
}
