using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Crash_Couese
{
    internal class StringInterpolation
    {
        public void Show() 
        {
            /* String interpolation = Allows us to insert variables into a string literal
             *                        precede a string literal with $
             *                        {} are placeholders for variables or expressions                     
             */
            String firstName = "Tkd";
            String lastName = "Abrar";
            int age = 20;

            //Console.WriteLine("My name is " + firstName + " " + lastName + ".");
            //Console.WriteLine(" and I am " + age); // Concatenation

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"And you are {age, 10} old.");// by addind a comma and a number we can specify the minimum width of the field, if the value is shorter than the specified width, it will be padded with spaces on the left (for positive numbers) or right (for negative numbers) to fill the width. In this case, the age will be right-aligned in a field of 10 characters.
        }
    }
}
