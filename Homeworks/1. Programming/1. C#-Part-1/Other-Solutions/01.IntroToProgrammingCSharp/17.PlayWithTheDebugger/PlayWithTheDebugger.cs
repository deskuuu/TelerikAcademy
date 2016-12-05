/*Problem 17. Play with the VS Debugger
Write a program that prints at the console the numbers from 1 to 1000, each at a separate line.
*/
namespace _17.PlayWithTheDebugger
{
    using System;

    class PlayWithTheDebugger
    {
        static void Main()
        {
            int start;
            int end;

            Console.WriteLine("Enter a start-point number: ");
            start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a end-point number: ");
            end = int.Parse(Console.ReadLine());

            PrintNumbersFromStartToEnd(start, end);
        }

        static void PrintNumbersFromStartToEnd(int start, int end)
        {
            if (start > end)
            {
                for (int i = start; i >= end; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
