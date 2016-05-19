//Write a program to convert hexadecimal numbers to binary numbers(directly).
using System;
namespace _05.Hexadecimal_to_binary
{
    class HexadecimalToBinary
    {
        static void HexToBinary(string number)
        {
            var hex = Convert.ToInt64(number, 16);
            var dec = Convert.ToString(hex, 2); 

            Console.WriteLine(dec);
        }


        static void Main()
        {
            var input = Console.ReadLine();

            HexToBinary(input);
        }
    }
}
