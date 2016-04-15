/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers N and x, 
calculates the sum S = 1 + 1!/x + 2!/x<sup>2</sup> + … + n!/x<sup>N</sup>.
*/
using System;
using System.Numerics;
class CalculateBy2Int
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        int counter = 1;
        double sum = 1;
        int nFactorial = 1;
        double xP = 1;

        while (counter <= N)
        {
           nFactorial *= counter;
           xP = Math.Pow(x, counter);
           sum += (nFactorial / xP);
           counter++;
         }
         Console.WriteLine("{0:F5}", sum);
    }
}
