/*Problem 16. Decimal to hexaDimal Number

Using loops write a program that converts an integer number to its hexaDimal representation.
The input is entered as long. The output should be a variable of type string.
*/
using System;
class DecimalTohexaDimalNum
{
    static void Main()
    {
        long decimalNum = long.Parse(Console.ReadLine());
        long result;
        string hexaD = null;

        if (decimalNum == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            while (decimalNum > 0)
            {
                result = decimalNum % 16;

                switch (result)
                {
                    case 10: hexaD += 'A'; break;
                    case 11: hexaD += 'B'; break;
                    case 12: hexaD += 'C'; break;
                    case 13: hexaD += 'D'; break;
                    case 14: hexaD += 'E'; break;
                    case 15: hexaD += 'F'; break;
                         default: hexaD += result.ToString(); break;
                }

                decimalNum /= 16;
            }

            for (int position = hexaD.Length - 1; position >= 0; position--)
            {
                Console.Write(hexaD[position]);
            }

            Console.WriteLine();
        }
    }
}
