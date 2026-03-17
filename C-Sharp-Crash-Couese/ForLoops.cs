using System;

namespace C_Sharp_Crash_Couese
{
    internal class ForLoops
    {
        public void Show() {

            // For Loop = Repeats some code a FINITE amount of times
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
             */
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy New Year!");
        }
    }
}
