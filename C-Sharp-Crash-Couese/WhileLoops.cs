using System;

namespace C_Sharp_Crash_Couese
{
    internal class WhileLoops
    {
        public void Show() 
        {
            // While loop = reqeats some code while some condition is true

            //Console.Write("Enter your name: ");
            //String name = Console.ReadLine();
            String name = "";

            while (name == "") 
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);
        }
    }
}
