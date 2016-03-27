/*Problem 12. Extract Bit from Integer

Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.
*/
using System;
class BitFromInteger
{
    static void Main()
    {
       Console.WriteLine("Write a integer number:");
       int number = int.Parse(Console.ReadLine());
       Console.WriteLine("Write a position of the bit:");
       int positionOfBit = int.Parse(Console.ReadLine());
       
       int bit  = number >> positionOfBit & 1;
       Console.WriteLine(bit)      
    }
    
}
