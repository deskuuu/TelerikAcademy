/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
*/
using System;
class CalculateNK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
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
