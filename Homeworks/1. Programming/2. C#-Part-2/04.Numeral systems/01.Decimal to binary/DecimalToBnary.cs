//Write a program that converts a decimal number N to its binary representation.
namespace _01.Decimal_to_binary
{
    using System;
    using System.Collections.Generic;

    class DecimalToBnary
    {
        static void DecimalToBin(long dec) // (int dec)
        {
            var item = new List<int>();
            string bin = string.Empty;
            int help;

            while (dec > 0)
            {
                help = (int)dec % 2;
                if (help != 0)
                {
                    item.Add(1);
                }
                else
                {
                    item.Add(0);
                }

                dec /= 2;
            }

            item.Reverse();

            foreach (var itemm in item)
            {
                //Console.Write(itemm);
                bin += itemm;
            }

            //remove leading zeros
            bin = bin.TrimStart(new char[] { '0' });

            Console.WriteLine(bin);
        }

        static void Main()
        {
            long dec = long.Parse(Console.ReadLine());
            // int decAotherWay= int.Parse(Console.ReadLine());
            // DecimalToBin(decAnotherWay);

            DecimalToBin(dec);
        }
    }
}
