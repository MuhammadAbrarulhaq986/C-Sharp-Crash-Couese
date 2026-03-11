using System;

namespace C_Sharp_Crash_Couese
{
    internal class ArithmeticOperators
    {
        public void Show()
        {
            //int firends = 5;
            //double firends = 5;
            int firends = 10;

            //firends = firends + 2;//First way
            //firends += 2; //Second way
            //firends++; //Third way (increment operator) adds 1 to the variable

            //firends = firends - 1;//First way
            //firends -= 1;
            //firends--;


            //firends = firends * 2;//First way
            //firends *= 2; //Second way

            //firends = firends  /2;//First way
            //firends /= 2; //Second way

            int remainder = firends % 2; //Modulus operator gives us the remainder of a division problem

            //Console.WriteLine(firends);
            Console.WriteLine(remainder);

        }
    }
}
