/*Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
*/

using System;

    class DecimalToBinaryNumber
{
        static void Main()
        {
        Console.WriteLine("Enter an integer number:");
        long input = long.Parse(Console.ReadLine());
        int counter = 0;
        long divide = input;
        string result = "";

        if (divide != 0)
        {
            result += divide % 2;
            divide = divide / 2;
            counter++;
            for (int i = counter - 1; i >= 0; i--)
            {
                Console.Write("decimal {0} = {1} binary", input, result);
            }
           
        }
        else
        {
            Console.WriteLine("Wrong input.");
        }
        Console.WriteLine();
    }
    }

