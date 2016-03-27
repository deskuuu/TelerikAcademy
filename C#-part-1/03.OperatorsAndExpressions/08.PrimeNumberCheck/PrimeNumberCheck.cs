/*Problem 8. Prime Number Check

Write a program that reads an integer N (which will always be less than 100 or equal)
and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
*/
using System;
class PrimeNumberCheck
{
     static void Main()
     {
        int number = int.Parse(Console.ReadLine());
        int divider = 2;
        double maxDivider = Math.Sqrt(number);
        bool Isprime = true;
        
        if (number <= 100)
        {
           while (Isprime && (divider <= maxDivider))
           {
              if (number % divider == 0)
              {
              	Isprime = false;
              }
              divider++;
           }
           Console.WriteLine(Isprime);
        }
     }
}
