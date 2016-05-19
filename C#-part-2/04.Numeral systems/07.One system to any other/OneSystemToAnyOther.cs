//Write a program to convert the number N from any numeral system of given base s to any other numeral system of base d.
using System;
namespace _07.One_system_to_any_other
{
    class OneSystemToAnyOther
    {
        static void SystemToOther(string number, int s, int d)
        {
            var system = Convert.ToString(number,2);
            var baseS = Convert.ToString(system, d);
           // var other = Convert.To(baseS, d).ToString();

            Console.WriteLine(baseS);
        }

        static void Main()
        {
            int s =  13;//int.Parse(Console.ReadLine());
            var input = "16"; //Console.ReadLine();
            int d = 9; //int.Parse(Console.ReadLine());

            SystemToOther(input, s, d);
        }
    }
}
