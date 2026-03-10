using System;

namespace C_Sharp_Crash_Couese
{
    public class UserInput
    {
        public void Show()
        {
            Console.WriteLine("What's your name?");
            String name = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");

        }
    }
}
