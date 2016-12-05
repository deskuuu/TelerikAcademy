//Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained array on the console.
namespace Allocate_array
{
    using System;

    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
