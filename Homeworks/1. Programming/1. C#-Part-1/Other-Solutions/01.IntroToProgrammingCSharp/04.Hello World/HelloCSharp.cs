/*Problem 4. Hello World
Create, compile and run a Hello World application - it should print the string Hello, C#! on the console.*/
namespace HelloWorld
{
    using System;

    public class HelloCSharp
    {
        public static void Main()
        {
            string textToPrint = "Hello, C#!"; //Console.ReadLine();

            PrintSomething(textToPrint);
        }

        static void PrintSomething(string textToPrint)
        {
            if (String.IsNullOrEmpty(textToPrint))
            {
                throw new ArgumentNullException("The text you want to print is missing.");
            }
            else
            {
                Console.WriteLine(textToPrint);
            }
        }
    }
}