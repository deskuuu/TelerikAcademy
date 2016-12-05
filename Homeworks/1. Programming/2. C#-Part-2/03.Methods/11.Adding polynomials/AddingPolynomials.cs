//Write a program that reads two polynomials and prints their sum.
namespace _11.Adding_polynomials
{
    using System;
    using System.Linq;

    class AddingPolynomials
    {
        static void AddPlynomials(int n, int[] a, int[] b)
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = a[i] + b[i];
            }

            Console.WriteLine(string.Join(" ", arr));
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] b = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            AddPlynomials(n, a, b);
        }
    }
}
