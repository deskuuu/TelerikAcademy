//Write a program that reads from the console a string of maximum 20 characters.If the length of the string is less than 20, the rest of the characters should be filled with*.
namespace _06.String_length
{
    using System;
    using System.Text;

    class StringLength
    {
        static void ModifyStr(string text)
        {
            StringBuilder input = new StringBuilder();
            input.Append(text);
            input = input.Replace("\\", string.Empty);
            int lenght = input.Length;
            int elseLenght = 0;

            if (lenght == 20)
            {
                Console.WriteLine(input);
            }
            else
            {
                elseLenght = 20 - lenght;
                input.Append('*', elseLenght);
                Console.WriteLine(input);
            }
        }

        static void Main()
        {
            string input = Console.ReadLine();
            //input = input.Replace(@"\", string.Empty);
            //Console.WriteLine(input.PadRight(20, '*'));

            ModifyStr(input);
        }
    }
}
