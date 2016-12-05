/*Problem 5. Print Name
Create a C# application that print your name on the console.
 */
namespace _05.Print_Name
{
    using System;

    class PrintName
    {
        static void Main()
        {
            string name;

            Console.WriteLine("Please, enter your name: ");
            name = Console.ReadLine().Trim();

            PrintYourName(name);
        }

        static void PrintYourName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Invalid or not entered name.Please, wrote it again. ");
            }

            Console.WriteLine($"Your name is: {name} :)");
        }
    }
}
