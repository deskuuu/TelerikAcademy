namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
 
    class SortedNumbers
    {
        static void Main()
        {
            var counter = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x));
            var devidableNumbers = new List<int>();
            var devidableWithOneNumbers = new List<int>();
            var otherNumbers = new List<int>();
            var sortedNumbers = new List<int>(numbers.Count());
 
            foreach (var number in numbers)
            {
                if (number % 3 == 0)
                {
                    devidableNumbers.Add(number);
                }
                else if (number % 3 == 1)
                {
                    devidableWithOneNumbers.Add(number);
                }
                else
                {
                    otherNumbers.Add(number);
                }
            }
 
            sortedNumbers.AddRange(devidableNumbers);
            sortedNumbers.AddRange(devidableWithOneNumbers);
            sortedNumbers.AddRange(otherNumbers);
 
            foreach (var item in sortedNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}