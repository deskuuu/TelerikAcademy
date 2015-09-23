/*Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
Examples:

n	    binary representation of n	p	v	binary result	   result
5	    00000000 00000101	        2	0	00000000 00000001	1
0	    00000000 00000000	        9      	100000010 00000000	512
15	    00000000 00001111	        1	1	00000000 00001111	15
5343	00010100 11011111	        7	0	00010100 01011111	5215
62241	11110011 00100001	       11	0	11110011 00100001	62241
*/
using System;

    class ModifyABit
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter the integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position of the bit:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of bit:");
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

            Console.WriteLine();
            Console.WriteLine(result1);
            Console.WriteLine();
            Console.WriteLine("As bynari number looks like: {0}", Convert.ToString(result1, 2));
        }
        else
        {
            Console.WriteLine("Error!");
        }

    }
    }

