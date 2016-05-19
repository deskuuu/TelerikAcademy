//Write a program that converts a hexadecimal number N to its decimal representation.
namespace _04.Hexadecimal_to_decimal
{
    using System;

    class HexadecimalToDecimal
    {
        static void HexToDecimal(string number)
        {
            var hex = Convert.ToInt64(number, 16); 
            var dec = Convert.ToString(hex, 10); 

            Console.WriteLine(dec);
        }


        static void Main()
        {
            var input = Console.ReadLine();

            HexToDecimal(input);
        }
    }
}
