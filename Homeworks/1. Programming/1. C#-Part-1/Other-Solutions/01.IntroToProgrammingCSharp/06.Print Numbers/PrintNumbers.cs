/*Problem 6. Print Numbers
Write a program that prints the numbers 1, 101 and 1001, each on a separate line. 
 */
namespace _06.Print_Numbers
{
    using System;

    class PrintNumbers
    {
        static void Main()
        {
            PrintFirstWay();

            // PrintSecondWay();
        }

        static void PrintFirstWay()
        {
            Console.WriteLine(1);
            Console.WriteLine(101);
            Console.WriteLine(1001);
        }

        static void PrintSecondWay()
        {
            Console.WriteLine("1\n101\n1001");
        }
    }
}
