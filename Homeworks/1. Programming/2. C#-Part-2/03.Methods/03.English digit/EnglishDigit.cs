//Write a program that reads a number and prints the result of the method.
namespace English_digit
{
    using System;

    class EnglishDigit
    {
        static void NumberAsWord(int n)
        {
            int number = n % 10;

            switch (number)
            {
                case 0: Console.WriteLine("zero");break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine");break;
                     default: Console.WriteLine("Not a valid, sorry! :)");break;
            }
        }

        static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            NumberAsWord(input);
        }
    }
}
