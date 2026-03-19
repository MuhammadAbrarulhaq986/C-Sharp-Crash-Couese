using System;
namespace C_Sharp_Crash_Couese
{
    internal class NestedLoops
    {
        public void Show()
        {
            /* Nested loops = loops inside of other loops User vary.
                              Used a lot in sorting algorithms and 2D arrays (arrays inside of arrays) 
                        */
            Console.Write("How many rows ?: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("How many columns ?: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("What symbol ?: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                    Console.WriteLine();
            }

        }
    }
}
