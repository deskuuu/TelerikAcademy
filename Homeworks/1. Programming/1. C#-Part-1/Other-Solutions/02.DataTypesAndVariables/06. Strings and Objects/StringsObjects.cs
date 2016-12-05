/*Problem 6. Strings_and_Objects
Declare two string variables and assign them with Hello and World. 
Declare an object variable and assign it with the concatenation of the first two variables 
(mind adding an interval between). Declare a third string variable and initialize it with the value 
of the object variable (you should perform type casting).
*/

namespace _06.Strings_and_Objects
{
    using System;

    class StringsObjects
    {
        static void Main()
        {
            string userFirstInputString = Console.ReadLine();
            string userSecondInputString = Console.ReadLine();

            StringsAndObjectsCast(userFirstInputString, userSecondInputString);
        }

        static void StringsAndObjectsCast(string firstString, string secondString)
        {
            object concatenatedString = firstString + " " + secondString;

            string outputStringWithCast = (string)concatenatedString;

            Console.WriteLine(outputStringWithCast);
        }
    }
}
