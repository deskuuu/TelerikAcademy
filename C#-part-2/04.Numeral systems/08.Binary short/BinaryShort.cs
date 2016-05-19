//Write a program that shows the binary representation of given 16-bit signed integer number N(the C# type short).
using System;
namespace _08.Binary_short
{
    class BinaryShort
    {
        static void RepresentBinary(short number)
        {
            var bin =Convert.ToString(number,2);
            var represent = bin.ToString().PadLeft(16,'0');

            Console.WriteLine(represent);
        }

        static void Main()
        {
            var input = Int16.Parse(Console.ReadLine());

            RepresentBinary(input);
        }
    }
}