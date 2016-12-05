//Write a program that reads a number and calculates and prints its square root.
namespace _01.Square_root
{
    using System;

    class SquareRoot
    {
        static void Main()
        {
            var input = Console.ReadLine();

            try
            {
                double result = Math.Sqrt(double.Parse(input));

                if (double.Parse(input) < 0)
                {
                    Console.WriteLine("Invalid number");
                }

                else
                {
                    Console.WriteLine("{0:F3}", result);
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
