using System;

namespace C_Sharp_Crash_Couese
{
    internal class IfElseStatements
    {
        public void Show()
        {
            // If statement = a basic form of decision making that allows you to execute a block of code if a specified condition is true
            /*
            Console.WriteLine("Please Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 100)
            {
                Console.WriteLine("You are too old to sign up!");
            }
            else if (age >= 18 )
            {
                Console.WriteLine("You are now signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet!");
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }
            */
            Console.WriteLine("Please Enter your age: ");
            String name = (Console.ReadLine());

            //if(name == "")
            if(name != "")
            {
                //Console.WriteLine("You did not enter your name!");
                Console.WriteLine("Hello " + name + "!");
            }
            else
            {
                //Console.WriteLine("Hello " + name + "!");
                Console.WriteLine("You did not enter your name!");
            }
        }
    }
}
