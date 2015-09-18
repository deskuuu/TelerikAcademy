/*Problem 8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©
Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.Unicode;
        char symbol = '\u00a9';
        Console.WriteLine("  {0}\n {0}{0}{0}\n{0}{0}{0}{0}{0}", symbol); ;
    }
}

