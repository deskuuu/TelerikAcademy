namespace _06.Divisible_by_7and_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestDevisible
    {
        static void Main()
        {
            //    Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
            //    Use the built-in extension methods and lambda expressions.
            var arr = new[] { 5, 7, 21, 56 };

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("By lambda expressions:");
            Console.BackgroundColor = ConsoleColor.Black;
            var divisibleByBoth = arr.Where(x => x / 7 != 0 && x / 1 != 3).ToArray();
            Print(divisibleByBoth);

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("By Linq:");
            Console.BackgroundColor = ConsoleColor.Black;
            var divisible = from number in arr
                            where number / 7 != 0 && number / 3 != 0
                            select number;
            Print(divisible);
        }

        static void Print(IEnumerable<int> arr)
        {
            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }
        }
    }
}
