/*Problem 6. Boolean Variable
Declare a Boolean variable called isFemale and assign an appropriate value 
corresponding to your gender. Print it on the console.
*/
namespace _05.Boolean_Variable
{
    using System;

    class BooleanVariable
    {
        static void Main()
        {
            PrintGender();
        }

        static void PrintGender()
        {
            Console.WriteLine("What is your gender?\nEnter 'M' for male or 'F' for famale :");

            char gender = char.Parse(Console.ReadLine().Trim().ToUpper());
            bool isFemale = gender == 'F';
            bool isValidGender = (gender == 'F' || gender == 'M');

            if (!char.IsLetter(gender))
            {
                throw new ArgumentException("Invalid input choice.Try again!");
            }

            if (isValidGender)
            {
                Console.WriteLine("Your gender is {0}", isFemale ? "female" : "male");
            }
            else
            {
                Console.WriteLine("You are an oder type of personallity.");
            }

        }
    }
}
