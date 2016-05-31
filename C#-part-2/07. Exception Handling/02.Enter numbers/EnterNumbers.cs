//Write a method ReadNumber(int start, int end) that enters an integer number in a given range(start, end ).
namespace _02.Enter_numbers
{
    using System;
  
    class EnterNumbers
    {
        static void ReadNumber()
        {
            int[] numbers = new int[11];
            numbers[0] = 1;

            try
            {
                for (int i = 0; i < numbers.Length-1; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine(string.Join(" < ", numbers));
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }

        static void Main()
        {
            ReadNumber();
        }
    }
}
