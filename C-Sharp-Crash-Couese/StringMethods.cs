using System;

namespace C_Sharp_Crash_Couese
{
    internal class StringMethods
    {
        public void Show()
        {
            String fullName = "Tkd Abrar";
            String phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper(); // Converts the string to uppercase
            //fullName = fullName.ToLower(); // Converts the string to lowercase 
            //Console.WriteLine(fullName);

            //phoneNumber =  phoneNumber.Replace("-", ""); // Replaces all occurrences of the specified character with another character
            //Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0, "Mr."); // Inserts a specified string at a specified index in the original string
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length); // Returns the number of characters in the string

            String firstName = fullName.Substring(0, 3); // Extracts a substring from the original string, starting at a specified index and with a specified length
            String lastName = fullName.Substring(4, 5); // Extracts a substring from the original string, starting at a specified index and with a specified length

            Console.WriteLine(firstName); 
            Console.WriteLine(lastName); 
        }
    }
}
