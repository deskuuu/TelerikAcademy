/*Problem 10. Employee Data
Declare the variables needed to keep the information for a 
single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
*/
namespace _10.Employee_Data
{
    using System;

    class EmployeeData
    {
        static void Main()
        {
            Console.WriteLine("Enter an employees first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter an employees last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter an employees age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an employees gender: ");
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter an employees personal ID number: ");
            string idNumber = Console.ReadLine();
            Console.WriteLine("Enter an employees uniqueNumber: ");
            string uniqueNumber = Console.ReadLine();

            PrintEmployeeInformation(firstName, lastName, age, gender, idNumber, uniqueNumber);
        }

        static void PrintEmployeeInformation(string firstName, string lastName, int age, char gender, string idNumber, string uniqueNumber)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("Invalid or missing first or last employees name.");
            }

            if (age < 1 || age > 130)
            {
                throw new ArgumentOutOfRangeException("Invalid age.Can`t be negative or greather than 130!");
            }

            if (!char.IsLetter(gender))
            {
                throw new ArgumentException("Invalid employees gender.");
            }

            if (string.IsNullOrEmpty(idNumber) || string.IsNullOrEmpty(uniqueNumber))
            {
                throw new ArgumentNullException("Imployye can`t missed ID number or unique number.");
            }

            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine($@"Employee`s information:
            First name => {firstName}
            Last name => {lastName}
            Age => {age}
            Gender => {gender}
            Personal ID number => {idNumber}
            Unique number => {uniqueNumber}");
        }
    }
}
