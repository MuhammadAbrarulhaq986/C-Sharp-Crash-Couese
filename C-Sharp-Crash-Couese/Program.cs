using System;
namespace C_Sharp_Crash_Couese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //============================================================================================================ 
            //User input file link
            // This tells Program.cs to go find your UserInput file
            /*
            UserInput inputLesson = new UserInput();
            // This tells it to run the "Show" method we just created
            inputLesson.Show();
            */
            /*
                        This tells Program.cs to go find your ArithmeticOperators
                         file and run the "Show" method we just created in that file
            */
            //=========================================================================================================================================

            //==== 4.File name: Arithmetic Operators ==================================================================================================
            //new ArithmeticOperators().Show();

            //==== 5.File name: Math Class ============================================================================================================
            //new MathClass().Show();

            //==== 6.File name: Hypotenuse Calculator =================================================================================================
            //new HypotenuseCalculator().Show();

            //==== 7.File name: String Methods ========================================================================================================
            //new StringMethods().Show();

            //==== 8.File name: If Else Statements ====================================================================================================
            //new IfElseStatements().Show();

            //==== 9.File name: Switch Statements =====================================================================================================
            //new Switches().Show();

            //==== 10.File name: Logical Operators && || ==============================================================================================
            //new LogicalOperators().Show();

            //==== 11.File name: While Loops ==========================================================================================================
            //new WhileLoops().Show();

            //==== 12.File name: For Loops ============================================================================================================
            //new ForLoops().Show();

            //==== 13.File name: Nested Loops =========================================================================================================
            //new NestedLoops().Show();

            //==== 14.File name: Number Guessing Game =================================================================================================
            //new NumberGuessing().Show();

            //==== 15.File name: Rock Paper Scissors Game =============================================================================================
            //new RockPaperScissors().Show();

            //==== 16.File name: Calculator ===========================================================================================================
            //new Calculator().Show();

            //==== 17.File name: Arrays ===============================================================================================================
            //new Arrays().Show();

            //==== 18.File name: For Each Loop ========================================================================================================
            //new ForEachLoop().Show();

            //==== 19.File name: Methods ==============================================================================================================
            //new Methods().Show();

            //==== 20.File name: Return Keyword ==============================================================================================================
            //new ReturnKeyword().Show();

            //==== 21.File name: Method Overloading ==============================================================================================================
            //new MethodOverloading().Show();

            //==== 22.File name: Method Overloading ==============================================================================================================
            //new ParamsKeyword().Show();

            //==== 23.File name: Method Overloading ==============================================================================================================
            //new ExceptionHandling().Show();

            //==== 24.File name: Conditional Operator ==============================================================================================================
            //new ConditionalOperator().Show();

            //==== 25.File name: String Interpolation ==============================================================================================================
            //new StringInterpolation().Show();

            //==== 26.File name: Multidimensional Arrays ==============================================================================================================
            //new MultidimensionalArrays().Show();

            //==== 27.File name: Classes ==============================================================================================================
            //new Classes().Show();

            //==== 28.File name: Objects_ ==============================================================================================================
            //new Objects_().SHow();

            //==== 29.File name: Constructors_ ==============================================================================================================
            //new Constructors_().Show();

            //==== 30.File name: Static Modifier ==============================================================================================================
            //new StaticModifier().Show();

            //==== 31.File name: Inheritance ==============================================================================================================
            //new Inheritance().Show();

            //==== 32.File name: Abstract Classes ==============================================================================================================
            //new AbstractClass().Show();

            //==== 33.File name: Array Of Objects ==============================================================================================================
            //new ArrayOfObjects().Show();

            //==== 34.File name: Objects As Arguments ==============================================================================================================
            //new ObjectsAsArguments().Show();

            //==== 35.File name: Method Overriding ==============================================================================================================
            //new MethodOverriding().Show();

            //==== 36.File name: ToString Method ==============================================================================================================
            //new ToStringMethod().Show();

            //==== 37.File name: Polymorphism==============================================================================================================
            new Polymorphism().Show();


            //=========================================================================================================================================
            Console.WriteLine();
            Console.ReadKey();          // Wait for a key press before closing the 

            /* ********___ TypeCasting_04 ___*********************************
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

                        //********___ Constants_03 ___*********************************
            /* Constants = are immutable values which are known at compile
                           time and do not change for the life of the program 
            */
            /*
            const double pi = 3.14159;
                        //pi = 425;
            Console.WriteLine(pi);
             */
            /*  *********___ Variables_02 ___*********************************
                        int x;          // Declaration 
                        x = 123;            // Initialization

                        int y = 321;            // Declaration and initialization

                        int z = x + y;          // Declaration, initialization and assignment

                        int age = 25;           // Whole Integer number
                        double height = 500.5;          // Decimal number
                        bool alive = false;             // True or False
                        char symbol = '@';          // Single character
                        String name = "Tkd";            // Sequence of characters

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
            *********___ OutPuts_01 ___*********************************
            Console.Write("I like Biryani!");
            Console.WriteLine("And its relly good!");
                        //Console.Beep();
            Console.WriteLine("TKD\nABRAR");
            */
        }
    }
}