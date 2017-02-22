namespace Modify_Bit
{
    using System;

    class ModifyBit
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var position = int.Parse(Console.ReadLine());
            var value = int.Parse(Console.ReadLine());

            var modifiedNumber = ModifyNumber(number, position, value);
            Console.WriteLine(modifiedNumber);
        }

        private static int ModifyNumber(int number, int position, int value)
        {
            int result = 0;

            if (value == 1)
            {
                int mask = 1 << position;
                result = mask | number;
            }
            else if (value == 0)
            {
                int mask = ~(1 << position);
                result = mask & number;
            }

            return result;
        }
    }
}
