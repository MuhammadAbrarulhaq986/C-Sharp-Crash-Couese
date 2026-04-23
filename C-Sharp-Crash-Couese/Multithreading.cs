using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp_Crash_Couese
{
    internal class Multithreading
    {
        public void Show()
        {
            /* Thread = An execution path of a program
                        We can use multiple thread to perform,
                        different task of our program at the same time.
                        Current thread running is "Main" thread 
                        Using System.Threading */

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);

            //Thread thread1 = new Thread(CountDown);
            //Thread thread2 = new Thread(CountUp);
            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));

            thread1.Start();
            thread2.Start();

            /*
            CountDown();
            CountUp();
            */
            /* Threading = A way to run multiple methods at the same time
                           We can use the Thread class to create and run threads */

            Console.WriteLine($"{mainThread.Name} is complete!");
        }
        public static void CountDown(string name)
        {
            for (int i = 10; i >= 0; i--) 
            {
                Console.WriteLine($"Time #1: {i} Seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is Complete!\n");
        }
        public static void CountUp( string name )
        {
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine($"Time #2: {i} Seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is Complete!\n");
        }
    }
}
