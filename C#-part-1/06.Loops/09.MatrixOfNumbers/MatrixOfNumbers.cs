/*Problem 9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
*/

using System;

    class MatrixOfNumbers
    {
        static void Main()
        {

        Console.WriteLine("Enter a positive integer (1 <= n <= 20)");
        int n = int.Parse(Console.ReadLine());
        int number = 1;

        if (n <= 20)
        {
            for (int cols = 1; cols <= n; cols++)
            {
                number = cols;
                for (int rows = 1; rows <= n; rows++)
                {
                    Console.Write("{0 }", number);
                    number++;
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Your input is wrong, try again!");
        }

    }
    }

