namespace AssignNull
{
    using System;

    class AssignNull
    {
        static void Main()
        {
            int? withNullValue = null;
            double? nullValue = null;

            Console.WriteLine($"Int with null value=> {withNullValue}");
            Console.WriteLine($"Double with null value + concatenated text=> {nullValue} + empty");
        }
    }
}
