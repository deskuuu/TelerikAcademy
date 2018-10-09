namespace Library.Common.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface IBook
    {
        IList<String> Authors { get; set; }
        int PublicationYear { get; }
        int PagesCount { get; }
    }
}
