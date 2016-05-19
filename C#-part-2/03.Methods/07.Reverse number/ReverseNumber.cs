//Write a method that reverses the digits of a given decimal number.
namespace _07.Reverse_number
{
    using System;

    class ReverseNumber
    {   //string way, but slow
        //static void ReverseDecimal(string n)
        //{
        //    char[] arr = n.ToCharArray();
        //    Array.Reverse(arr);

        //    Console.Write(arr);
        //}

        static void Reversed(char[] arr)
        {
            Array.Reverse(arr);

            Console.Write(arr);
        }

        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            Reversed(input);
        }
    }
}
