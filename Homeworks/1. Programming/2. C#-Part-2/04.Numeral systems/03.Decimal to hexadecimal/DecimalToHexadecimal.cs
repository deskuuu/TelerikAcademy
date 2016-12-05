//Write a program that converts a decimal number N to its hexadecimal representation.
namespace _03.Decimal_to_hexadecimal
{
    using System;

    class DecimalToHexadecimal
    {
        static void DecimalToHex(long dec)
        {

            var bin = Convert.ToString(dec, 16).ToUpper(); //ToUpper for letter

            Console.WriteLine(bin);
        }

        static void Main()
        {
            var input = long.Parse(Console.ReadLine());

            DecimalToHex(input);
        }
    }
}
