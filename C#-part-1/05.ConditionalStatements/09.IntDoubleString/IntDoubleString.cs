/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
*/

using System;

    class IntDoubleString
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Please,enter your choice :\n1 for int-->\n2 for double-->\n3 for string-->");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1 :
                int number = int.Parse(Console.ReadLine());
                number++;
                Console.WriteLine("{0}", number);
                break;
           case 2 :
                double numberT = double.Parse(Console.ReadLine());
                numberT++;
                Console.WriteLine("{0}", numberT);
                break;
           case 3 :
                string numberTh = Console.ReadLine();
                string numberThr;
                numberThr = numberTh + "*";
                Console.WriteLine("{0}", numberThr);
                break;

        }

        }
  }

