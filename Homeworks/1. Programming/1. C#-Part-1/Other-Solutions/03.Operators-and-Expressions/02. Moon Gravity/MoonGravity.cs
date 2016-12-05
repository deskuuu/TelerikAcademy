/*Problem 2. Gravitation on the Moon
Write a program that calculates the weight 
of a man on the moon by a given weight W(as a floating-point number) on the Earth.
*/
namespace _02.Moon_Gravity
{
    using System;

    class MoonGravity
    {
        static void Main()
        {
            double weightOnEarth = double.Parse(Console.ReadLine());

            double weightOnMoon= CalculateMoonGravity(weightOnEarth);

            // Console.WriteLine($"{weightOnMoon:F3}");
            Console.WriteLine("{0:F3}", weightOnMoon);
        }

        static double CalculateMoonGravity(double weightOnEarth)
        {
            const int MoonPercentWeight = 17;
   
            double weightOnMoon = ((weightOnEarth * MoonPercentWeight) / 100);

            return weightOnMoon;
        }
    }
}
