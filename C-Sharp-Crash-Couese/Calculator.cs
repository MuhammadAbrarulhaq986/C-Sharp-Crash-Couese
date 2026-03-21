using System;
namespace C_Sharp_Crash_Couese
{
    internal class Calculator
    {
        public void Show()
        {
            do
            {   
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("==================");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("==================");
        
            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an option: ");
            Console.WriteLine("\t+: Add");
            Console.WriteLine("\t-: Subtract");
            Console.WriteLine("\t*: Multiply");
            Console.WriteLine("\t/: Divide");
            
            Console.Write("Enter an option: ");


            switch (Console.ReadLine()) 
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} =  " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Your result: {num1} - {num2} =  " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Your result: {num1} * {num2} =  " + result);
                    break;
                case "/":
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} / {num2} =  " + result);
                    break;
                default:
                    Console.WriteLine("That was not a valid option");
                    break;
                }
                Console.WriteLine("Would you like to continue? (Y = Yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Thanks for using the calculator. Goodbye!");
        }

    }
}
