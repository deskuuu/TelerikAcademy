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
          int k = 0;;
     
          for (int i = 1; i <= number; i++)
          {
             if (number % i == 0)
             {
                 k++;
             }
          }
          if (k == 2)
          {
             Console.WriteLine("true");
          }
          else
          {
             Console.WriteLine("false");
          }
     }
}
