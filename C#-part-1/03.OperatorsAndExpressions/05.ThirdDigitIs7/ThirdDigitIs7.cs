/*Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.
Examples:

n	Third digit 7?
5	false
701	true
9703	true
877	false
777877	false
9999799	true
*/
using System;

  class ThirdDigit
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Write an integer: ");
        int number = int.Parse(Console.ReadLine());
        bool lastDigitIsSeven = (number / 100) % 10 == 7;
        Console.WriteLine("{0} {1}", "The third digit is 7 from right-to-left -", lastDigitIsSeven);
    }
}
