/*Problem 1. Odd or Even Integers
Write a program that reads an integer from the console, uses an expression to check if given integer is odd or even,
and prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.
*/
namespace _01.Odd_or_Even
{
    using System;

    class OddOrEven
    {
        static void Main()
        {
            int numberToCheck = int.Parse(Console.ReadLine());

            bool isEven = CheckOddOrEven(numberToCheck);

            // Console.WriteLine(isEven ? $"even {numberToCheck}" : $"odd {numberToCheck}");
            Console.WriteLine(isEven ? "even " + numberToCheck : "odd " + numberToCheck); // because bgcoder!
        }

        static bool CheckOddOrEven(int numberToCheck)
        {
            bool isEven = true;

            if ((numberToCheck & 1) == 1)
            {
                isEven = false;
            }

            return isEven;
        }
    }
}
