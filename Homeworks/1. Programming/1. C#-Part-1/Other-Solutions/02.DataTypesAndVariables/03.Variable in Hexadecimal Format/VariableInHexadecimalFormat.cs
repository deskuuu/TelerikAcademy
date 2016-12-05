/*Problem 3. Variable in Hexadecimal Format
Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
Use Windows Calculator to find its hexadecimal representation.
Print the variable and ensure that the result is 254.
*/
namespace _03.Variable_in_Hexadecimal_Format
{
    using System;
    using System.Globalization;

    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            string hexInput = Console.ReadLine();

            PrintInHexadecimalFormat(hexInput);
        }

        static void PrintInHexadecimalFormat(string hex)
        {
            int number = Int32.Parse(hex, NumberStyles.AllowHexSpecifier); // works without "\0x" part

            Console.WriteLine(number);
        }
    }
}
