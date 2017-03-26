namespace Reffactor_Loop
{
    using System;

    public class Loop
    {
        private const int EXPECTED_VALUE = 666;
        private const string VALUE_FOUND_MESSAGE = "Value Found";

        public void MakeModification(int[] array, int to)
        {
            for (int index = 0; index < to; index++)
            {
                if (index == EXPECTED_VALUE)
                {
                    Console.WriteLine(VALUE_FOUND_MESSAGE);

                    return;
                }

                if (index % 10 == 0)
                {
                    Console.WriteLine(array[index]);

                    if (array[index] == EXPECTED_VALUE)
                    {
                        index = EXPECTED_VALUE;
                    }
                }
                else
                {
                    Console.WriteLine(array[index]);
                }
            }
        }
    }
}
