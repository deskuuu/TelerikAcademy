/*Problem 14. Modify Bit

We are given an integer number N(read from the console), a bit value v(read from the console as well) (v = 0 or 1) 
and a position P(read from the console). Write a sequence of operators (a few lines of C# code) that modifies N to hold 
the value v at the position P 
from the binary representation of N while preserving all other bits in N. Print the resulting number on the console.
*/
using System;
class ModifyABit
{
   static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            int mask0 = ~(1 << p);
            int result0 = mask0 & n;
            Console.WriteLine(result0);
        }
        else if (v== 1)
        {
            int mask1 = 1 << p;
            int result1 = n | mask1;
            Console.WriteLine(result1);
        }
    }
}
