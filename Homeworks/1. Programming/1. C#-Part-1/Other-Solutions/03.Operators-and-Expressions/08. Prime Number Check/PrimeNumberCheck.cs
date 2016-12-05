/*Problem 8. Prime Number Check
Write a program that reads an integer N (which will always be less than 100 or equal)
and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
*/
namespace _08.Prime_Number_Check
{
    using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            string isPrimeCheck = CheckPrimeNumber(inputNumber);
            Console.WriteLine(isPrimeCheck);
        }

        static string CheckPrimeNumber(int numberToCheck)
        {
            bool isPrime = false;
            int counter = 0;

            for (int i = 1; i <= numberToCheck; i++)
            {
                if (numberToCheck % i == 0)
                {
                    counter++;
                }
            }

            if (counter==2)
            {
                isPrime = true;
            }

            return isPrime.ToString().ToLower();
        }
    }
}
