//Write a program to check if in a given expression the(and ) brackets are put correctly.
namespace _03.Correct_brackets
{
    using System;

    class CorrectBrackets
    {
        static void Main()
        {
            var input = Console.ReadLine();
            int countOpen = 0, countClose = 0;


            //check how many times we have brackets
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    countOpen++;
                }
                else if (input[i] == ')')
                {
                    countClose++;
                }
            }
            //check if brackets are correct

            if (countOpen == countClose)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

        }
    }
}
