/*Problem 14. PrintASCIITable
Write a program that prints the visible characters of the ASCII 
table on the console(characters from 33 to 126 including).
*/
namespace _14.Print_the_ASCII_Table
{
    using System;

    class PrintASCIITable
    {
        static void Main()
        {
            int inputFrom = 32; //int.Parse(Console.ReadLine());
            int inputTo = 126; // int.Parse(Console.ReadLine());

            PrintASCIITableFromTo(inputFrom, inputTo);
        }

        static void PrintASCIITableFromTo(int from, int to)
        {
            for (int asciiSymbol = from; asciiSymbol <= to; asciiSymbol++)
            {
                Console.Write((char)asciiSymbol);
            }
        }
    }
}
