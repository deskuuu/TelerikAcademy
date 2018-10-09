namespace Library.Factories
{
    using System.Collections.Generic;

    using Library.Common.Contracts;
    using Library.Common.Exceptions;
    using Library.Models;

    public class BookFactory : IBookFactory
    {
        public IList<IBook> ReadBooks(string input)
        {
            IList<IBook> books = new List<IBook>();

            var title = string.Empty;
            var authors = new List<string>();
            var publisher = string.Empty;
            var publicationYear = int.MinValue;
            var pagesCount = int.MinValue;

            while (input != null)
            {
                var info = input.Split(':');

                var text = info[0];
                switch (text.ToLower())
                {
                    case "author": authors.Add(info[1]); break;
                    case "title": title = text; break;
                    case "publisher": publisher = text; break;
                    case "published": publicationYear = int.Parse(text); break;
                    case "pages": pagesCount = int.Parse(text); break;
                    default: throw new InvalidFieldException("Some of book parameters are invalid!");
                }

                IBook book = this.CreateBook(title,authors, publisher, publicationYear, pagesCount);
                books.Add(book);
            }

            return books;
        }

        private IBook CreateBook(string title, IList<string> authors, string publisher, int publicationYear, int pagesCount)
        {
            return new Book(title, authors, publisher, publicationYear, pagesCount);
        }
    }
}
