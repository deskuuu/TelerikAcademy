/*Prblem 14.BitExchange
 
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 
of given 32-bit unsigned integer(read from the console).
 */
using System;
class BitExchange
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            n = ((~(7u << 24 | 7u << 3)) & n) | (((n & (7u << 3)) << 21) | ((n & (7u << 24)) >> 21));
 
            Console.WriteLine(n);
    }
}