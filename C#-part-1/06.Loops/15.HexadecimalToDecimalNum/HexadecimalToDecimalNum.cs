/*Problem 15. hexaDimal to Decimal Number

Using loops write a program that converts a hexaDimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
*/

using System;

    class hexaDimalToDecimalNum
    {
        static void Main()
        {
        Console.WriteLine("Enter a hexaDimal integer:");
        string hexadecimal = Console.ReadLine();
        long decimalNum = 0;
        long pow = 1;

        for (int i = hexadecimal.Length - 1; i >= 0; i--)
        {
            int digit;
            switch (hexadecimal[i])
            {
                case 'A':
                    digit = 10;
                    break;
                case 'B':
                    digit = 11;
                    break;
                case 'C':
                    digit = 12;
                    break;
                case 'D':
                    digit = 13;
                    break;
                case 'E':
                    digit = 14;
                    break;
                case 'F':
                    digit = 15;
                    break;
                default:
                    digit = hexadecimal[i] - 48;
                    break;
            }
            pow *= 16;
            decimalNum += digit * pow;       
        }

        Console.WriteLine("Decimal number is: " + decimalNum);
    }
    }

