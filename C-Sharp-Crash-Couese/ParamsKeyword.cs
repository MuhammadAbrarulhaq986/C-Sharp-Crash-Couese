using System;
namespace C_Sharp_Crash_Couese
{
    internal class ParamsKeyword
    {
        public void Show() 
        {
            /*
            Params Keyword = A method parameter that takes a variable number of arguments.
                             The parameter type must be a single-dimension array and it must be the last parameter in the method.
            */
            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);
            
            Console.WriteLine(total);
            Console.ReadLine();
        }
        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price; 
            }
            return total;
        }
    }
}
