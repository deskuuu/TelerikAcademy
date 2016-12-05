/*Problem 13. ComparingFloats
Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.
*/
namespace _13.Comparing_Floats
{
    using System;

    class ComparingFloats
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            PrintComparedOutput(firstNumber, secondNumber);
        }

        static void PrintComparedOutput(double firstNumber, double secondNumber)
        {
            const double precisionWithSixNumbersAfterDecimalPoint = 0.000001;

            bool areEqual = Math.Abs(firstNumber-secondNumber) < precisionWithSixNumbersAfterDecimalPoint;

            Console.WriteLine(areEqual.ToString().ToLower());
        }
    }
}
