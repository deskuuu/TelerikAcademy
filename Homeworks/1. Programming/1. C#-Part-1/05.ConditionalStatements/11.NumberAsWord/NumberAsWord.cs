/*Problem 11.* Number as Words

Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
*/

using System;
class NumberAsWord
{
    static void Main()
    {
        Console.WriteLine("Enter a number[0-999]:");
        int number = int.Parse(Console.ReadLine());
        string asWord;
        
        witch (number)
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
            case 10:asWord = "ten";break;
            case 20:asWord = "twenty";break;
            case 30:asWord = "thirty";break;
            case 40:asWord = "forty";break;
            case 50: asWord = "fifty";break;
            case 60:asWord = "sixty";break;
            case 100:asWord = "one hundred";break;
            case 200:asWord = "two hundred";break;
            case 300: asWord = "three hundred"; break;
            case 400: asWord = "four hundred"; break;
            case 500: asWord = "five hundred"; break;
            case 601: asWord = "six hundred and one"; break;
            case 725: asWord = "seven hundred and twenty-five"; break;
            case 850: asWord = "eight hundred and fifty"; break;
            case 999: asWord = "nine hundred and ninety-nine"; break;
                    default: asWord = "some number";break;
            }
            Console.WriteLine("{0}",asWord);
        }
    }
