using System;
class BitSwap
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int bit1 = int.Parse(Console.ReadLine());
        int bit2 = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int countBit2 = 0;

        for (int i = bit1; i < bit1 + end; i++)
        {
            int mask = 1 << i;
            int firstBit = (int)((number & mask) >> i);

            mask = 1 << bit2 + countBit2;
            int secondBit = (int)((number & mask) >> bit2 + countBit2);

            if (firstBit == 0)
            {
                mask = ~(1 << bit2 + countBit2);
                number = (uint)(number & mask);
            }
            else if (firstBit == 1)
            {
                mask = 1 << bit2 + countBit2;
                number = (uint)(number | mask);
            }
            if (secondBit == 0)
            {
                mask = ~(1 << i);
                number = (uint)(number & mask);
            }
            else if (secondBit == 1)
            {
                mask = 1 << i;
                number = (uint)(number | mask);
            }
            countBit2++;
        }
        Console.WriteLine(number);

    }
}