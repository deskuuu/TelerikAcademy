/*Problem 7. Print First and Last Name

Create console application that prints your first and last name, each at a separate line.
*/
using System;
class FirstAndLastName
{
    static void Main()
    {
    	string firstName = Console.ReadLine();
    	string lastName = Console.ReadLine();

        Console.WriteLine("Your name is: {0} {1}", firstName, lastName);
    }
}

