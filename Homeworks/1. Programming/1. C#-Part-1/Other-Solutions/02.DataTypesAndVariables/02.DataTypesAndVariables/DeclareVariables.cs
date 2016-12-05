﻿/*Problem 1. Declare Variables
Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
*/
namespace _02.DataTypesAndVariables
{
    using System;

    class DeclareVariables
    {
        static void Main()
        {
            PrintVariables();
        }

        static void PrintVariables()
        {
            ushort first = 52130;
            sbyte second = -115;
            uint third = 4825932;
            sbyte fourth = 97;
            short fifth = -10000;

            Console.WriteLine($"{first}\n{second}\n{third}\n{fourth}\n{fifth}");
        }
    }
}
