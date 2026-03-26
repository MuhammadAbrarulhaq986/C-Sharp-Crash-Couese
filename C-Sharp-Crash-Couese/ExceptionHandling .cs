using System;
namespace C_Sharp_Crash_Couese
{
     class ExceptionHandling
    {
        public void Show()
        {
            /*
            Exception = Errors that occur during exections
                      try = try some code that is considered "Dangerous" 
                      catch = catches and handles exceptions when they occur
                      finally = always executes regardless if exceptions is caught or not
            */
            double x;
              double  y;
            double result;

            try
            {
                Console.WriteLine("Enter numbar 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter numbar 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("Result: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter only numbers!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You Can not Divide by Zero! Stupid!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally 
            {  
                Console.WriteLine("Thanks for using this program!");
            }
        }
    }
}

