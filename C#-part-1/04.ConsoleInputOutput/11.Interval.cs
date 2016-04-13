/*Problem 11.Interval

Write a program that reads two positive integer numbers N and M and 
prints how many numbers exist between
them such that the reminder of the division by 5 is 0.
 */
using System;
class Interval
{
    static void Main()
    {
    	int n = int.Parse(Console.ReadLine());
    	int m = int.Parse(Console.ReadLine());
    	int counter = 0;
    	
    	for (int i = Math.Min(n, m) + 1;i< Math.Max(n, m); i++)
    	{
    		if (i % 5 == 0)
    		{
    			counter++;
    		}
    		
    	}
    	Console.WriteLine(counter);
    }
}