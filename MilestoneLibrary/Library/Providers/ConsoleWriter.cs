namespace Library.Providers
{
    using System;

    using Library.Common.Contracts;

    public class ConsoleWriter : IWriter
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
