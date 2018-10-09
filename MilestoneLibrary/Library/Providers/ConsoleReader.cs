namespace Library.Providers
{
    using System;

    using Library.Common.Contracts;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
