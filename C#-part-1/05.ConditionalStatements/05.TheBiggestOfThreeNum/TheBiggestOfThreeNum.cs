/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
*/

using System;
using System.Collections.Generic;
using System.Linq;
class MultiplicationSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double max = 0;

        List<double> numbers = new List<double>();
        numbers.Add(a);
        numbers.Add(b);
        numbers.Add(c);

        numbers.Sort();
        foreach (double number in numbers)
        {
            max = numbers.Last();
        }
        Console.WriteLine(max);
    }
}
