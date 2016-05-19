//Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.
namespace _14.Integer_calculations
{
    using System;
    using System.Linq;

    class IntegerCalculations
    {
        static void Main()
        {
            int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Array.Sort(a);
            int min = a[0];
            int max = a[4];
            decimal average = (a[0] + a[1] + a[2] + a[3] + a[4]) / 5.0m;
            int sum = a[0] + a[1] + a[2] + a[3] + a[4];
            int product = a[0] * a[1] * a[2] * a[3] * a[4];

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine("{0:F2}", average);
            Console.WriteLine(sum);
            Console.WriteLine(product);
        }
    }
}
