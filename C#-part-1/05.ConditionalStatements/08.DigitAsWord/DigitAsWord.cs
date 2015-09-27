/*Problem 8. Digit as Word

Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.
*/

using System;
class DigitAsWord
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a digit (0-9)");
        int digit = int.Parse(Console.ReadLine());
        string asWord;

        switch (digit)
        {

            case 0: asWord = "zero"; break;
            case 1: asWord = "one"; break;
            case 2: asWord = "two"; break;
            case 3: asWord = "three"; break;
            case 4: asWord = "four"; break;
            case 5: asWord = "five"; break;
            case 6: asWord = "six"; break;
            case 7: asWord = "seven"; break;
            case 8: asWord = "eight"; break;
            case 9: asWord = "nine"; break;

            default: asWord = "not a digit"; break;
        }
        Console.WriteLine("{0}", asWord);

    }
 }



