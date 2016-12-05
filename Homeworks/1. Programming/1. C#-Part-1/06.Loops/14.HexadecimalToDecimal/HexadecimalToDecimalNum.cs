/*Problem 15. hexaDimal to Decimal Number

Using loops write a program that converts a hexaDimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.

*/

using System;
using System.Collections.Generic;
class hexaDimalToDecimalNum
{
    static Dictionary<char, int> hexdecval = new Dictionary<char, int>{
        {'0', 0},
        {'1', 1},
        {'2', 2},
        {'3', 3},
        {'4', 4},
        {'5', 5},
        {'6', 6},
        {'7', 7},
        {'8', 8},
        {'9', 9},
        {'a', 10},
        {'b', 11},
        {'c', 12},
        {'d', 13},
        {'e', 14},
        {'f', 15},
    };

    static decimal HexToDec(string hex)
    {
        long result = 0;
        hex = hex.ToLower();

        for (int i = 0; i < hex.Length; i++)
        {
            char valAt = hex[hex.Length - 1 - i];
            result += hexdecval[valAt] * (long)Math.Pow(16, i);
        }

        return result;
    }

    static void Main()
    {
        string hex = Console.ReadLine();

        Console.WriteLine(HexToDec(hex));

    }
}

