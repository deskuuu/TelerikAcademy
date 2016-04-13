/*Problem 2. Gravitation on the Moon

Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
*/
using System;
class GravitationOnTheMoon
{
     static void Main()
     {
         float weight = float.Parse(Console.ReadLine());
         float moonWeight = (weight * 17) / 100;
          
         if (weight > 0)
         {
              Console.WriteLine("{0:F3}",moonWeight);
         }
     }
}

