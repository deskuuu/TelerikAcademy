/*Problem 9. ExchangeVariableValues
Declare two integer variables a and b and assign them with 5 and 10 and 
after that exchange their values by using some programming logic. 
Print the variable values before and after the exchange.
*/
namespace _09.Exchange_Variable_Values
{
    using System;

    class ExchangeVariableValues
    {
        static void Main()
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            ExchangeLogic(numberA, numberB);
        }

        static void ExchangeLogic(double a, double b)
        {
            Console.WriteLine($"Before exchange: \na: {a}\nb: {b}");

            double helperLogic = 0.31;

            a *= helperLogic;
            b /= helperLogic;

            Console.WriteLine($"After exchange: \na: {a}\nb: {b}");
        }
    }
}
