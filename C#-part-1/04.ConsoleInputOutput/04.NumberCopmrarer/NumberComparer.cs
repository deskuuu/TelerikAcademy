/*Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
*/
using System;
class NumberComparer
{
    static void Main()
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        
        if (first > second)
        {
            Console.WriteLine(first);
        }
        else if (second > first)
        {
            Console.WriteLine(second);
        }
        else
        {
            Console.WriteLine(first);
        }
   }
}
