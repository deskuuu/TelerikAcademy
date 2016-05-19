//Write a program that reads two arrays representing positive integers and outputs their sum.

namespace _08.Number_as_array
{
    using System;
    using System.Linq;

    class NumberAsArray
    {

        static int[] Reversed(int[] arr)
        {
            int l = arr.Length;
            var reversed = new int[l];

            for (int i = 0; i < l; i++)
            {
                reversed[l - i - 1] = arr[i];
            }

            return reversed;
        }

        static int GetValue(int[] num)
        {
            string aS = string.Empty;
            int l = num.Length;

            for (int i = 0; i < l; i++)
            {
                aS += num[i];
            }

            int value = int.Parse(aS);

            return value;
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main()
        {
            var parameters = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var b = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] aRev = Reversed(a);
            int[] bRev = Reversed(b);
            int sum = GetValue(aRev) + GetValue(bRev);
            string result = Reverse(sum.ToString());

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}
