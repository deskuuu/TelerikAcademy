//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.
namespace _17.Subset_K_with_sum_S
{
    using System;
    using System.Linq;

    class SubsetKWithSum
    {
        static int[] FillArray(int n)
        {
            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        static string FindKElementsWithSum(int[] arr, int numbers, int sum)
        {
            bool haveSum = false;
            string output = string.Empty;

            int summ = arr.Sum();

            if (summ / numbers > sum)
            {
                haveSum = true;
            }

            output = haveSum ? "yes" : "no";

            return output;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            var output = FindKElementsWithSum(FillArray(n), k, s);
            Console.WriteLine(output);
        }
    }
}
