/*Problem 8. Square root
Write a program that calculates the square root of the number 12345 and prints it on the console.
 */
namespace _08.Square_root
{
    using System;

    class SquareRoot
    {
        static void Main()
        {
            double number;

            // Console.WriteLine("Enter a number to calculate square root: ");
            number = 12345; // double.Parse(Console.ReadLine());

            CalculateSquareRoot(number);
        }

        static void CalculateSquareRoot(double number)
        {
            double root = Math.Sqrt(number);

            Console.WriteLine(root);
        }
    }
}