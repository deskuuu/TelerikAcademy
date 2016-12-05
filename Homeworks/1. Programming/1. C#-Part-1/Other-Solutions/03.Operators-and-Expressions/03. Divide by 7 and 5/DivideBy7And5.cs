/*Problem 3. Divide by 7 and 5
Reads an integer number from the console.
Stores in a variable if the number can be divided by 7 and 5 without remainder.
Prints on the console "true NUMBER" if the number is divisible without remainder
by 7 and 5. Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number.
*/
namespace _03.Divide_by_7_and_5
{
    using System;

    class DivideBy7And5
    {
        static void Main()
        {
            int numberToCheck = int.Parse(Console.ReadLine());

            bool isDevidableWithoutRemainder = CheckNumberIsDevidableWithoutRemainder(numberToCheck);

            // Console.WriteLine(isDevidableWithoutRemainder ? $"true {numberToCheck}" : $"false {numberToCheck}");
            Console.WriteLine(isDevidableWithoutRemainder ? "true " + numberToCheck : "false " + numberToCheck);
        }

        static bool CheckNumberIsDevidableWithoutRemainder(int numberToCheck)
        {
            bool isDevidableWithoutRemainder = ((numberToCheck % 5 == 0) && (numberToCheck % 7 == 0));

            if (!isDevidableWithoutRemainder)
            {
                isDevidableWithoutRemainder = false;
            }

            return isDevidableWithoutRemainder;
        }
    }
}
