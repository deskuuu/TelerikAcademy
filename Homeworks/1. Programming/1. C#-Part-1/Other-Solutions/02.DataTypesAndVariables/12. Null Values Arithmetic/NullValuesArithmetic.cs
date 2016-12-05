/*Problem 12. NullValuesArithmetic
Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/
using System;

namespace _12.Null_Values_Arithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? intWithNull = null;
            double? doubleWithNull = null;

            Console.WriteLine($@"Before manipulation:
                       int with null: {intWithNull}
                       double with null: {doubleWithNull}");

            intWithNull = 10;
            doubleWithNull = 45.9;

            Console.WriteLine($@"After manipulation:
                       int with null: {intWithNull}
                       double with null: {doubleWithNull}");
        }
    }
}
