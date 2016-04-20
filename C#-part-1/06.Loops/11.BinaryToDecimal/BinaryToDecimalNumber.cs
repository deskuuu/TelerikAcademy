/*Problem 13. Binary to Decimal Number

Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
*/
using System;
class BinaryToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        long sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[input.Length - i - 1] == '0')
            {
                continue;
            }
            else
            {
                sum += (int)Math.Pow(2, i);
            }
        }
        Console.WriteLine(sum);
    }
}
