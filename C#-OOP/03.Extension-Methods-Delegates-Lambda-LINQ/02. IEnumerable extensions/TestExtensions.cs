//Problem 2. IEnumerable extensions
//Implement a set of extension methods for IEnumerable<T> 
//that implement the following group functions: sum, product, min, max, average.
namespace _02.IEnumerable_extensions
{
    using System;
    using System.Collections.Generic;

    class TestExtensions
    {
        static void Main()
        {
            List<int> collection = new List<int>();
            collection.Add(200);
            collection.Add(100);
            collection.Add(170);
            Console.WriteLine($"Sum= {collection.Sum()}");
            Console.WriteLine($"Product= {collection.Product()}");
            Console.WriteLine($"Min= {collection.Min()}");
            Console.WriteLine($"Max= {collection.Max()}");
            Console.WriteLine($"Average= {collection.Average()}");
        }
    }
}
