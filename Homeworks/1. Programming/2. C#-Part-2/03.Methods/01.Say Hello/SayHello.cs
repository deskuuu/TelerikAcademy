//Write a method that asks the user for his name and prints Hello, <name>!

namespace _01.Say_Hello
{
    using System;

    class SayHello
    {
        static void SayHi(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Main()
        {
            var name = Console.ReadLine();

            SayHi(name);
        }
    }
}
