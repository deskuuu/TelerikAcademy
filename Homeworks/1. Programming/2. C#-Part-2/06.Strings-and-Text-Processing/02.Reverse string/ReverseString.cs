//Write a program that reads a string, reverses it and prints the result on the console.
namespace _02.Reverse_string
{
    using System;
    using System.Linq;

    class ReverseString
    {
        static void Main()
        {
            var input = Console.ReadLine().ToArray();
            Array.Reverse(input);
            Console.WriteLine(input);
        }
    }
}
