﻿/*Problem 7. Quotes in Strings

Write a program that outputs The "use" of quotations causes difficulties.
*/

using System;
class QuotesInStrings
    {
        static void Main()
        {
            string firstWay= "The \"use\" of quotations causes difficulties.";
            string secondWay = @"The ""use"" of quotations causes difficulties.";
            
            Console.WriteLine("{0}\n{1}", firstWay, secondWay);
        }
    }

