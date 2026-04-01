using System;
namespace C_Sharp_Crash_Couese
{
    internal class OverloadedConstructors
    {
        public void Show() 
        {
            /*  Overloaded Constructors = technique to create multiple constructors ,
             *                            With a different set of parameters
             *                            name + parameters = signature 
            */
            // Creating a Pizza Object
             Pizza pizza = new Pizza("Stuffed Crust", "Red sauce", "mozzarella");

            
        }
    }
    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread) // This is a constructor
        {
            this.bread = bread;
        }
        public Pizza(String bread, String sauce) // This is a constructor
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(String bread, String sauce, String cheese) // This is a constructor
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese, String topping) // This is a constructor
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }

}
