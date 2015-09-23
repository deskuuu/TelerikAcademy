/*Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
Examples:

n	Divided by 7 and 5?
3	false
0	true
5	false
7	false
35	true
140	true
*/
using System;
    class DivideBy7And5
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Write an integer:");
        int number = int.Parse(Console.ReadLine());
        bool divideByFive = number % 5 == 0;
        bool divideBySeven = number % 7 == 0;
        bool divideBoth = divideByFive && divideBySeven;
        Console.WriteLine("The number can be divided by seven and five - {0}", divideBoth);

    }
}

