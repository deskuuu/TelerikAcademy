﻿/*Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/

using System;
class NullValuesArithmetic
{
        static void Main()
        {
            int? nullValueOne = null;
            double? nullValueTwo = null;
            Console.WriteLine("{0}\n{1}", nullValueOne,nullValueTwo);
            
            nullValueOne = 7;
            Console.WriteLine(nullValueOne.GetValueOrDefault());
            
        }
}

