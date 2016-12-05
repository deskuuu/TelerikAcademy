/*Problem 2. Float or double?
Which of the following values can be assigned to a variable of type float
and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? 
*/
namespace _02.FloatOrDouble
{
    using System;

    class FloatOrDouble
    {
        static void Main()
        {
            PrintFloatOrDouble();
        }
       
        static void PrintFloatOrDouble()
        {
            double first = 34.567839023d;
            float second = 12.345f;
            float third = 8923.1234857f;
            float fourth = 3456.091f;

            Console.WriteLine($"{first}\n{second}\n{third}\n{fourth}");
        }
    }
}
