using System;
using System.Collections.Generic;
namespace C_Sharp_Crash_Couese
{
    internal class Lists
    {
        public void Show() 
        {
            /* List = data structure that represents a list of objects that can be accessed by index.
             *        Similar to array, but can dynamically increase/decrease in size.
             *        Using System.Collections.Generic;          
            */

            /* Array Example 
            String[] food = new string[3];

            food[0] = "Pizza";
            food[1] = "Burger";
            food[2] = "Sanwitch";
             */

            List<String> food = new List<String>();

            //food.Add("fries");
            food.Add("pizza");
            food.Add("burger");
            food.Add("sanwitch");
            food.Add("fries");

            //food.Remove("fries"); // remove item from list
            //food.Insert(0, "Ice Cream"); // insert item at index
            //Console.WriteLine(food.Count); // count of items in list
            //Console.WriteLine(food.IndexOf("Pizza")); // index of item in list
            //Console.WriteLine(food.LastIndexOf("fries")); // index of last occurrence of item in list
            //Console.WriteLine(food.Contains("pizza")); // check if item exists in list
            //food.Sort(); // sort list
            //food.Reverse(); // reverse list
            //food.Clear(); // clear list
            String[] foodArray = food.ToArray(); // convert list to array

            //Console.WriteLine(food[0]); like array you can access list by index
            foreach (String item in foodArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
