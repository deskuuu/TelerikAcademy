/*Problem 8. Digit as Word

Write a program that read a digit (0-9) from the console, and depending on the input, shows the digit as a word (in English).
*/
using System;
class DigitAsWord
{
    static void Main()
    {
        string digit = Console.ReadLine();
        string asWord;

        switch (digit)
        {
            case "0": asWord = "zero"; break;
            case "1": asWord = "one"; break;
            case "2": asWord = "two"; break;
            case "3": asWord = "three"; break;
            case "4": asWord = "four"; break;
            case "5": asWord = "five"; break;
            case "6": asWord = "six"; break;
            case "7": asWord = "seven"; break;
            case "8": asWord = "eight"; break;
            case "9": asWord = "nine"; break;
            default: asWord = "not a digit"; break;
        }
        Console.WriteLine(asWord);
    }

}
