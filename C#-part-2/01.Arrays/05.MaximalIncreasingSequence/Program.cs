/*Write a program that finds the maximal increasing sequence in an array.
*/
using System;

    class MaximalIncreasingSequence
    {
        static void Main( )
        {

        int lenght = int.Parse(Console.ReadLine());
        Console.WriteLine("Write array:");
        int[] toCheck = new int[lenght];
        int counter = 1;
        int bigCounter = 0;
        int element = 0;

        for (int i = 0; i < toCheck.Length; i++)
        {
            toCheck[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < toCheck.Length - 1; i++)
        {
            if (toCheck[i] == toCheck[i + 1])
            {
                counter++;

            }
            else
            {
                if (counter > bigCounter)
                {
                    bigCounter = counter;
                    element = toCheck[i];

                }
                counter = 1;
            }

            Console.WriteLine("Sequence lenght is {0} of number {1}", bigCounter, element);
        }
    }
    }

