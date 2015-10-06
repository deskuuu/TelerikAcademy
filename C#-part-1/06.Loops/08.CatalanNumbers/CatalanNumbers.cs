/*Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
*/

using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a number n:");
        uint n = uint.Parse(Console.ReadLine());
        int nFactorial = 1;
        int twoNFactorial = 1;
        int nPlusOneFactorial = 1;
        int sum;

        for (int i = 1; i <= n + 1; i++)
        {
            if (i <= n)
            {
                nFactorial *= i;
            }
            nPlusOneFactorial *= i;
        }
        for (int i = 1; i <= 2 * n; i++)
        {
            twoNFactorial *= i;
        }
           sum = twoNFactorial / (nPlusOneFactorial * nFactorial);
           Console.WriteLine(sum);
    }                   
}
          
         
     
    

