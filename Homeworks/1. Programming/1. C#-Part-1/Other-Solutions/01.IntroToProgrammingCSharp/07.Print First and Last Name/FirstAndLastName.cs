/*Problem 7. Print first and last name
Create console application that prints your first and last name, each at a separate line.
 */
namespace _07.Print_First_and_Last_Name
{
    using System;

    class FirstAndLastName
    {
        static void Main()
        {
            string firstName;
            string lastName;

            Console.WriteLine("Enter your first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            lastName = Console.ReadLine();

            PrintFirstAndLastName(firstName, lastName);
        }

        static void PrintFirstAndLastName(string firstName, string lastName)
        {
            if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("You already missed one of your names.");
            }
            else
            {
                Console.WriteLine($"Your first name is: {firstName}\nYour last name is: {lastName}");
            }
        }
    }
}