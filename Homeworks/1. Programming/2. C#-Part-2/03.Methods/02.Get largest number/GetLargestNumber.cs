//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

namespace _02.Get_largest_number
{
    using System;
    using System.Linq;

    class GetLargestNumber
    {
        static int LargestNumber(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers.Last();
        }

        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine(LargestNumber(input));
        }
    }
}
