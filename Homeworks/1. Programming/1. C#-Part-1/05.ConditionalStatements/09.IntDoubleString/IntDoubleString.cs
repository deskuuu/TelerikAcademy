/*Problem 9. Play with Int, Double and String

Write a program that, depending on the first line of the input, reads an int, double or string variable.

If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
*/
using System;
class IntDoubleString
{
    static void Main()
    {
         string choice = Console.ReadLine();
         int numInt;
         double numDouble;
         string strChoice;

        switch (choice)
        {
           case "integer" : numInt = int.Parse(Console.ReadLine());Console.WriteLine(numInt + 1);break;
           case "real" : numDouble = double.Parse(Console.ReadLine());Console.WriteLine("{0:F2}", numDouble + 1);break;
           case "text" : strChoice = Console.ReadLine();Console.WriteLine("{0}*", strChoice);break;
        }
    }
}
