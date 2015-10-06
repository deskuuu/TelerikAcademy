/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
Examples:

n	k	n! / k!
5	2	60
6	5	6
8	3	6720
*/
using System;

    class CalculateNK
    {
        static void Main()
        {

        Console.WriteLine("Enter a number n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number k:");
        int k = int.Parse(Console.ReadLine());
        int nFactorial = 1;
        int kFactorial = 1;
        int counter = 1;
        int div = 1;

       while (counter <= n)
        {
            nFactorial *= counter;
            
            if (counter <= k)
            {
                kFactorial *= counter;
            }
            div = nFactorial / kFactorial;
            counter++;         
        }
        Console.WriteLine(div);
        }
    }
    
    

