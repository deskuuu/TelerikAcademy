namespace _05.Generic_class
{
    using System;

    class TestGeneric
    {
        static void Main()
        {
            var elements = new GenericList<int>();
            elements.AddElement(1);
            elements.AddElement(2);
            elements.AddElement(4);
            elements.AddElement(3);
            Console.WriteLine("Your elements:");
            elements.ToString();
            Console.WriteLine($"Min:{elements.Min()}");
            Console.WriteLine($"Max:{elements.Max()}");
            Console.WriteLine("Insert 10 at position 0 and remove index 2:");
            elements.InsertAt(0, 10);
            elements.RemoveAt(1);
            elements.ToString();

            Console.WriteLine("Find 3 at position:");
            Console.WriteLine(elements.Find(3));
            Console.WriteLine("Cleared elements:");
            elements.Clear();
            Console.WriteLine(elements.ToString());
        }
    }
}
