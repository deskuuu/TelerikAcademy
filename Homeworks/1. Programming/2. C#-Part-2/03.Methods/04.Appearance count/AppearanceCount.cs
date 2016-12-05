//Write a method that counts how many times given number appears in a given array.
namespace _04.Appearance_count
{
    using System;
    using System.Linq;

    class AppearanceCount
    {
        static int CountApperance(int[] numbers, int toFind)
        {
            int counter = 0;

            foreach (var item in numbers)
            {
                if(item==toFind)
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int toFind = int.Parse(Console.ReadLine());
            int count = CountApperance(numbers,toFind);

            Console.WriteLine(count);
        }
    }
}
