/*Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
*/
using System;
using System.Collections.Generic;
using System.Linq;
class BiggestOfFive
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double max = 0;

        List<double> numbers = new List<double>();
        numbers.Add(a);
        numbers.Add(b);
        numbers.Add(c);
        numbers.Add(d);
        numbers.Add(e);

        numbers.Sort();
        foreach (double number in numbers)
        {
            max = numbers.Last();
        }
        Console.WriteLine(max);
    }
}
