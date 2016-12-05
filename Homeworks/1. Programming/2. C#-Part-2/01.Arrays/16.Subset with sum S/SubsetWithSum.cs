//Write a program to find if there exists a subset of the elements of the array that has a sum S.
namespace _16.Subset_with_sum
{
    using System;
    using System.Linq;

    class SubsetSum
    {

        static int[] FillArray(string[] input)
        {
            var numbers = new int[input.Length];


            for (int i = 0; i < input.Length; i++)
            {
                if (!string.IsNullOrEmpty(input[i]))
                {
                    numbers[i] = int.Parse(input[i]);
                }
            }

            return numbers;
        }

        static string FindASubset(int[] input, int sum)
        {
            bool isSum = false;
            string result = string.Empty;
            int haveSum = input.Sum();

            result = haveSum >= sum ? "yes" : "no";

            return result;
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' });
            var sum = int.Parse(Console.ReadLine());

            var resul = FindASubset(FillArray(input), sum);
            Console.WriteLine(resul);
        }

    }
}
