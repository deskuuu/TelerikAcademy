/*Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
Examples:

numbers	sum
3	    90
20	
60	
10	
5	    6.5
2	
-1	
-0.5	
4	
2	
1	   1
1
*/
using System;

    class SumOfNNumb
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter a numbers n (by space) to sum :");
        string[] numbers = Console.ReadLine().Split(' ');
        double sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += double.Parse(numbers[i]);
            Console.WriteLine("\n {0}",numbers[i]);
        }
        Console.WriteLine("The numbers are : {0}", numbers.Length);
        Console.WriteLine("The sum is: {0}",sum);

        }
    }

