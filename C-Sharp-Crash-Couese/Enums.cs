using System;
using System.Runtime.InteropServices.WindowsRuntime;
namespace C_Sharp_Crash_Couese
{
    internal class Enums
    {
        public void Show()
        {
            /* Enums = special "class" that contains a set of named integer constants.
                       Use enums when you have values that you know will not change,
                       To gey the integer value from an item, you must explicitly convert to an int

                       name = integer */
            //Console.WriteLine(Planets.Pluto.ToString() + "  is a Planet");
            //Console.WriteLine(Planets.Pluto + "  is a Planet");

            /*
                Console.WriteLine(Planets.Mreccury + "  is Planet #" +  (int)Planets.Mreccury);
                Console.WriteLine(Planets.Pluto+ "  is Planet #" +  (int)Planets.Pluto);
             */

            String name = PlanetsRadius.Earth.ToString();
            int radius = (int)PlanetsRadius.Earth;
            double volume = Volume(PlanetsRadius.Earth);

            Console.WriteLine($"Planet: {name}");
            Console.WriteLine($"Radius: {radius} km");
            Console.WriteLine($"Volume: {volume} km^3");
        }
        public static double Volume(PlanetsRadius radius) 
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }
    public enum Planets
    {
        Mreccury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }
    public enum PlanetsRadius
    {
        Mreccury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}

