/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
*/

using System;

class MinMaxSum
{
    static void Main()
    {

        int[] numbers = { 3, 2, 5, 1 };
        decimal sum = 0;
 
        if (numbers[2] > numbers.Length)
        {
            sum =  numbers[0] + numbers[1] + numbers[2] + numbers[3];
            Console.WriteLine("The maximal number is {0}", numbers[2]);
            Console.WriteLine("Th sum is {0}",sum);
        }
        if (numbers[3] < numbers.Length)
        {
            Console.WriteLine("The minimal number is {0}", numbers[3]);       
            decimal range = sum / 4;
            Console.WriteLine("The range is {0:0.00}",range);
        }
        
    }
}

