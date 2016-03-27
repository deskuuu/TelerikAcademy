/*Problem 2. Gravitation on the Moon

Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
*/
using System;
class GravitationOnTheMoon
{
     static void Main(string[] args)
     {
         Console.WriteLine("Please write your weight :");
         float weight = float.Parse(Console.ReadLine());
         float moonWeight = (weight * 17) / 100;
          
         if (weight > 0)
         {
         	Console.WriteLine("Your weight on the Moon is {0:0.000} ",moonWeight);
         }
         else
         {
            Console.WriteLine("Sorry, your result is incorrect.");
         }
     }
}

