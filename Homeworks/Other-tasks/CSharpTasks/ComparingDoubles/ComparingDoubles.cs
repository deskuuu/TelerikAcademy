namespace ComparingDoubles
{
    using System;

    class ComparingDoubles
    {
        static void Main()
        {
            const double epsilon = 0.000001;

            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            var difference = first - second;

            var areEqual = (first == second || Math.Abs(difference) < epsilon);

            Console.WriteLine(areEqual);
        }
    }
}
