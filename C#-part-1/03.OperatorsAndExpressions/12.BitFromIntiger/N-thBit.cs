/*Problem 12. Extract Bit from Integer

Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.
*/
using System;
class NthBit
{
    static void Main()
    {
       int number = int.Parse(Console.ReadLine());
       int positionOfBit = int.Parse(Console.ReadLine());
       
       int bit  = number >> positionOfBit & 1;
       Console.WriteLine(bit);      
    }
    
}
