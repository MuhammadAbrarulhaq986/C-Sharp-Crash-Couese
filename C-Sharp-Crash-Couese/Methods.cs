using System;
namespace C_Sharp_Crash_Couese
{
    internal class Methods
    {
        public void Show()
        {
            // Method = Performs a sections of the code, whenever it's Called "Invoked".
            //          Let's us reuse code w/o writing it multiple times,
            //          makes our code easier to read, and easier to debug.

            String name = "Abrar";
            int age = 20;

            singHappyBirthday(name, age);
        }
        static void singHappyBirthday(String birthdayBoy, int yearsOld) // Beside name we can put asy word of choice,
        {
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday dear " + birthdayBoy); // same as here. 
            Console.WriteLine("You are " + yearsOld + " years old"); // same as here. 
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine();
        }
    }
}
