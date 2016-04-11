/*Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
*/

using System;
class TheBiggestOfFiveNum
    {
        static void Main()
        {
           double a = double.Parse(Console.ReadLine());
           double b = double.Parse(Console.ReadLine());
           double c = double.Parse(Console.ReadLine());
           double d = double.Parse(Console.ReadLine());
           double e = double.Parse(Console.ReadLine());
           double biggest = 0;
           
           if (a > b && a > c && a > d && a > e)
           {
               biggest = a;
           }
           else if (b > a && b > c && b > d && b > e)
           {
               biggest = b;
           }
           else if (c > b && c > a && c > d && c > e)
           {
               biggest = c;
           }
           else if (d > b && d > c && d > a && d > e)
           {
               biggest = d;
           }
           else
           {
               biggest = e;
           }
           Console.WriteLine(biggest);
        }
}
