//Write a program to return the string with maximum length from an array of strings.
namespace _017.Longest_stringg
{
    using System;
    using System.Linq;

    class TestLongestString
    {
        static void Main()
        {
            var arr = new[] { "des","HeYyYy","BeHAPPY :)"};
            MaxString(arr);
        }

        static void MaxString(string[] arr)
        {
            var max = arr.OrderByDescending(str => str.Length).ToArray()[0];
            Console.WriteLine(max);
        }
    }
}
