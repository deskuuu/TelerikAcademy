//Problem 1. StringBuilder.Substring
//Implement an extension method Substring(int index, int length) 
//for the class StringBuilder that returns new StringBuilder and has the 
//same functionality as Substring in the class String.
namespace _01.StringBuilder.Substring
{
    using System;
    using System.Text;

    class TestStringBuilger
    {
        static void Main()
        {
            var text = new StringBuilder("Hello pretty child!Have a wonderfull day :)");
            var substring = text.Substring(6, 13);

            Console.WriteLine(substring);
        }
    }
}
