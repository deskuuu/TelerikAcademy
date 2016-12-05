/*Problem 6. Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
Puts the last digit in the first position: dabc (in our example 1201) and prints the result.
Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.
*/
namespace _06.Four_Digit_Number
{
    using System;
    using System.Text;

    class FourDigitNumber
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SumDigitsInNumber(inputNumber));
            Console.WriteLine(ReverseDigitsInNumber(inputNumber));
            Console.WriteLine(PutLastDigitFirst(inputNumber));
            Console.WriteLine(ExchandeDigitsInNumber(inputNumber, 2, 3));
        }

        static int SumDigitsInNumber(int numberToManipulate)
        {
            string numberToManipulateString = numberToManipulate.ToString();
            int inputLength = numberToManipulateString.Length;
            int sumOfDigits = 0;

            for (int number = 0; number <= inputLength - 1; number++)
            {
                sumOfDigits += int.Parse(numberToManipulateString[number].ToString());
            }

            return sumOfDigits;
        }

        static string ReverseDigitsInNumber(int numberToManipulate)
        {
            string numberToManipulateString = numberToManipulate.ToString();
            int inputLength = numberToManipulateString.Length;
            StringBuilder reversedNumber = new StringBuilder();

            for (int number = inputLength - 1; number >= 0; number--)
            {
                reversedNumber = reversedNumber.Append(numberToManipulateString[number]);
            }

            return reversedNumber.ToString();
        }

        static string PutLastDigitFirst(int numberToManipulate)
        {
            string numberToManipulateString = numberToManipulate.ToString();
            int inputLength = numberToManipulateString.Length;
            StringBuilder helper = new StringBuilder();
            string lastDigit = numberToManipulateString[inputLength-1].ToString();
            string lastComeFirstDigit = string.Empty;

            for (int i = 0; i < inputLength - 1; i++)
            {
                helper.Append(numberToManipulateString[i]);
            }

            lastComeFirstDigit = lastDigit + helper.ToString();

            return lastComeFirstDigit;
        }

        static string ExchandeDigitsInNumber(int numberToManipulate, int firstDigitToExchange, int secndDigitToExchange)
        {
            string reversedNumber = ReverseDigitsInNumber(numberToManipulate);
            int reversedLength = reversedNumber.Length;
            StringBuilder exchanged = new StringBuilder();

            for (int start = reversedLength - 1; start >= 0; start--)
            {
                exchanged.Append(reversedNumber[start]);
            }

            if (reversedLength > 1)
            {
                char temp = exchanged[firstDigitToExchange - 1];
                exchanged[firstDigitToExchange - 1] = exchanged[secndDigitToExchange - 1];
                exchanged[secndDigitToExchange - 1] = temp;
            }

            return exchanged.ToString();
        }
    }
}
