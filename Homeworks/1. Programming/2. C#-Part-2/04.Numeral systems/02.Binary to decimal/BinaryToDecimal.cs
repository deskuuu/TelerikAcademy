//Write a program that converts a binary number N to its decimal representation.
namespace _02.Binary_to_decimal
{
    using System;

    class BinaryToDecimal
    {
        static void BinToDecimal(string bin)
        {
           string dec = Convert.ToInt64(bin, 2).ToString();
            Console.WriteLine(dec);
        }

        static void Main()
        {
            string bin = Console.ReadLine();

            BinToDecimal(bin);
        }
    }
}
