/*Problem 5. Boolean Variable

Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
Print it on the console.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BooleanVariable
{
    static void Main(string[] args)
    {
        bool isFemale = true;
        Console.Write("Am I female? ");
        Console.WriteLine(isFemale ? "Yes" : "No");
    }
}

