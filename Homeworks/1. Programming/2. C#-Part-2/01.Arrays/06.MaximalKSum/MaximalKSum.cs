//Write a program that reads two integer numbers N and K and an array of N elements from the console.Find the maximal sum of K elements in the array.
namespace _06.MaximalKSum
{
    using System;

    class MaximalKSum
    {
        static int[] FillArray(int length)
        {
            var arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        static int FindMaximalSum(int[] arr, int numbers)
        {
            var sum = 0;

            Array.Sort(arr);

            for (int i = arr.Length - numbers; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        static void Main()
        {
            var length = int.Parse(Console.ReadLine());
            var numbers = int.Parse(Console.ReadLine());

            var output = FindMaximalSum(FillArray(length), numbers);
            Console.WriteLine(output);
        }
    }
}
