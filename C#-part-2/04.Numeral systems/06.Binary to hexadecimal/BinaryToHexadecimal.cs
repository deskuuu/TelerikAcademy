//Write a program to convert binary numbers to hexadecimal numbers(directly).
using System;
namespace _06.Binary_to_hexadecimal
{
    class BinaryToHexadecimal
    {
        static void BinToHex(string number)
        {
            var bin = Convert.ToInt64(number, 2);
            var hex = Convert.ToString(bin, 16).ToUpper();

            Console.WriteLine(hex);
        }

        static void Main()
        {
            var input = Console.ReadLine();

            BinToHex(input);
        }
    }
}
