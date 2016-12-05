/*Problem 11. Bitwise: Extract Bit #3
Using bitwise operators, write a program that uses an expression to find the value of the bit
at index 3 of an unsigned integer read from the console.
The bits are counted from right to left, starting from bit 0.
The result of the expression should be either 1 or 0. Print it on the console.
*/
namespace _11._3rd_Bit
{
    using System;

    class thirdBit
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int bitPosition = 3;// int.Parse(Console.ReadLine());
            int bitAtPosition = FindNthBit(inputNumber, bitPosition);

            Console.WriteLine(bitAtPosition);
        }

        static int FindNthBit(int number, int bitToFind)
        {
            int bitAtNPosition = (number >> bitToFind) & 1;

            return bitAtNPosition;
        }
    }
}
