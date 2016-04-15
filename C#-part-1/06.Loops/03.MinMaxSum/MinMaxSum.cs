/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of N integer numbers and returns the minimal, 
the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
*/
using System;
using System.Collections.Generic;
using System.Linq;
class MinMaxSumAvg
{
    static void Main()
    {
    	int n = int.Parse(Console.ReadLine());
    	int num, min = 0, max = 0, sum = 0;
        double avg = 0;
        
        List<int> numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
           num = int.Parse(Console.ReadLine());
           numbers.Add(num);
        }
        
        numbers.Sort();

        foreach (int number in numbers)
        {
           min = numbers.First();
           max = numbers.Last();
           sum = numbers.Sum(x => Convert.ToInt32(x));;
           avg = (double)sum / n;
        }
        
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", avg);
    }
}
