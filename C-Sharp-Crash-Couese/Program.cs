using System;
namespace C_Sharp_Crash_Couese
{
    internal class Program
    {
               static void Main(string[] args)
        {
            // This tells Program.cs to go find your UserInput file
            UserInput inputLesson = new UserInput();

            // This tells it to run the "Show" method we just created
            inputLesson.Show();


            Console.ReadKey(); // Wait for a key press before closing the console




            /* ********   TypeCasting_04   *********************************
            Type casting = converting a value to a different data type
                            using when we accept user input (string) 
                            different data types can do different thing.

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            String f = Convert.ToString(e);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(j.GetType());
             */

            //******** Constants_03 * ********************************
            /* Constants = are immutable values which are known at compile
                           time and do not change for the life of the program 
            */
            /*
            const double pi = 3.14159;
            //pi = 425;
            Console.WriteLine(pi);
             */
            /*  ********  Variables_02   *********************************
                        int x; // Declaration 
                        x = 123; // Initialization

                        int y = 321;// Declaration and initialization

                        int z = x + y; // Declaration, initialization and assignment

                        int age = 25;// Whole Integer number
                        double height = 500.5; // Decimal number
                        bool alive = false; // True or False
                        char symbol = '@'; // Single character
                        String name = "Tkd"; // Sequence of characters

                        Console.WriteLine("Hello " + name);
                        Console.WriteLine("Your age is " + age);
                        Console.WriteLine("Your hight is " + height + "cm");
                        Console.WriteLine("Are you Alive " + alive);
                        Console.WriteLine("Your Symbol is  " + symbol);
                        */
            /*
            Console.WriteLine(z);
            Console.WriteLine(x);
            Console.WriteLine(y);
            String userName = symbol + name;
            Console.WriteLine("Your username is :" + userName);
            */
            /*
            ******** OutPuts_01 *********************************
            Console.Write("I like Biryani!");
            Console.WriteLine("And its relly good!");
            //Console.Beep();
            Console.WriteLine("TKD\nABRAR");
            */
        }
    }
}