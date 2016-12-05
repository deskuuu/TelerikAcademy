/*Problem 5. Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/
namespace _05.Third_Digit
{
    using System;

    class ThirdDigit
    {
        static void Main()
        {
            int numberToCheck = int.Parse(Console.ReadLine());

            IsThirdDigit7(numberToCheck);
        }

        static void IsThirdDigit7(int numberToCheck)
        { 
            int thirdDigit = (numberToCheck / 100) % 10;
            bool isThirdDigit7 = thirdDigit == 7;

            // Console.WriteLine(isThirdDigit7 ? "true" : $"false {thirdDigit}");
            Console.WriteLine(isThirdDigit7 ? "true" : "false " + thirdDigit);
        }
    }
}
