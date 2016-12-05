/*Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/
using System;
class ThirdDigit
{
     static void Main()
     {
         int number = int.Parse(Console.ReadLine());
         int digit = (number / 100) % 10;
         bool lastDigitIsSeven = digit == 7;
         
         if (lastDigitIsSeven)
         {
            Console.WriteLine("true");
         }
         else
         {
            Console.WriteLine("false {0}", digit);
         }
         
     }
}
