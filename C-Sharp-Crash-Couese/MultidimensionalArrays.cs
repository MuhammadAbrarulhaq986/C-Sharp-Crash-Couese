using System;
namespace C_Sharp_Crash_Couese
{
    internal class MultidimensionalArrays
    {
        public void Show() 
        {
            /*
            String[] ford = {"Mustang", "F-150", "Explorer"};
            String[] chevy = {"Corvetta", "Camaro", "Sliverado"};
            String[] toyota = {"Corolla", "Camry", "Rav4"};
             */
            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" }, 
                                     { "Corvetta", "Camaro", "Sliverado" },
                                     { "Corolla", "Camry", "Rav4" } };
            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";


            /*
            foreach (String car in parkingLot)
            {
                Console.WriteLine(car);
            }
             */
            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
