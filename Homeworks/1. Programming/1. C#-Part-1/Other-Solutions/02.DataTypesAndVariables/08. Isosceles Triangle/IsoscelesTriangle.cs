/*Problem 8. IsoscelesTriangle
Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

   ©

  © ©

 ©   ©

© © © ©
*/
namespace _08.Isosceles_Triangle
{
    using System;

    class IsoscelesTriangle
    {
        static void Main()
        {
            PrintExample();
        }

        static void PrintExample()
        {
            Console.WriteLine(@"
                   ©

                  © ©

                 ©   ©

                © © © ©");
           
        }
    }
}
