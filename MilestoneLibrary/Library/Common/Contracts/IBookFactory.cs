namespace Library.Common.Contracts
{
    using System.Collections.Generic;

    public interface IBookFactory
    {
        IList<IBook> ReadBooks(string input);
    }
}
