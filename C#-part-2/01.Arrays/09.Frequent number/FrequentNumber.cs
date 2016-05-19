//Write a program that finds the most frequent number in an array of N elements.
namespace _09.Frequent_number
{
    using System;

    class FrequentNumber
    {
        static int[] FillArray(int length)
        {
            var arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        static int[] FidMostFrequentN(int[] arr)
        {
            var mostFrequentN = new int[2];
            int maxCounter = 1;
            int currentCounter = 1;
            int mostNumber = 0;

            if (arr.Length == 1)
            {
                mostNumber = arr[0];
            }

            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    currentCounter++;
                }
                else
                {
                    if (currentCounter > maxCounter)
                    {
                        maxCounter = currentCounter;
                        mostNumber = arr[i];
                        currentCounter = 1;
                    }
                    else
                    {
                        currentCounter = 1;
                    }
                }
            }

            if (currentCounter > maxCounter)
            {
                maxCounter = currentCounter;
                mostNumber = arr[arr.Length - 1];
            }

            mostFrequentN[0] = mostNumber;
            mostFrequentN[1] = maxCounter;

            return mostFrequentN;
        }

        static void PrintInput(int[] arr)
        {
            Console.WriteLine("{0} ({1} times)", arr[0], arr[1]);
        }

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            PrintInput(FidMostFrequentN(FillArray(input)));
        }
    }
}
