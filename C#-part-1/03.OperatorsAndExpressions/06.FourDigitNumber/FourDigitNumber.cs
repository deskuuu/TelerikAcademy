/*Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
Examples:

n	sum of digits	reversed	last digit in front	second and third digits exchanged
2011	4	1102	1201	2101
3333	12	3333	3333	3333
9876	30	6789	6987	9786
*/
using System;

  class FourDigitNumber
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter a four-digit number like 2011 :");
        int number = int.Parse(Console.ReadLine());

        int d = number % 10;
        int c = (number / 10) % 10;
        int b = (number / 100) % 10;
        int a = (number / 1000) % 10;

        while (number < 1000 || number > 9999)
        {
            Console.WriteLine("Invalid syntax.Write only four-digit number.(Number cannot start with 0!) ");
            number = int.Parse(Console.ReadLine());
        }


       

        Console.WriteLine("{0} {1}" ,"Your number is :", number); //Print number
        Console.WriteLine("{0} {1}{2}{3}{4}", "The sum is:", a + b + c + d); //Sum the number
        Console.WriteLine("{0} {1}{2}{3}{4}", "Reserved your number looks like:", d, c, b, a); //Reserve
        Console.WriteLine("{0} {1}{2}{3}{4}", "The last digit becomes first:", d, b, c, a); //Last become first
        Console.WriteLine("{0} {1}{2}{3}{4}", "The second digit becomes third", a, c, b, a); //Second exchange third
                          
    }
}

