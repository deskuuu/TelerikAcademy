namespace Library
{
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    using Library.Common.Contracts;

    public class LibrarySystem
    {
        private string name;

        private IList<IBook> books;
        private IList<IPlayable> cds;
        private IList<IPlayable> dvds;
        private IList<IPlayable> bluRays;

        public LibrarySystem(IList<IBook> books,IList<IPlayable> cds, IList<IPlayable> dvds, IList<IPlayable> bluRays, string name = "Mailstone")
        {
            this.name = name;
            this.books = books;
            this.cds = cds;
            this.dvds = dvds;
            this.bluRays = bluRays;
        }

        public IList<IBook> Books { get; set; }
        public IList<IPlayable> Cds { get; set; }
        public IList<IPlayable> Dvds { get; set; }
        public IList<IPlayable> BluRays { get; set; }

        public IList<IBook> FindBooks(string searchString)
        {
            var foundBooks = new List<IBook>();

            string pattern = @"\w+";
            var regex = new Regex(pattern);
            var matches = regex.Matches(searchString);

            var strBuilder = new StringBuilder();
            for (int i = 0; i < matches.Count; i++)
            {
                strBuilder.Append(matches[i] + " ");
            }

            foreach (var book in this.books)
            {
                if (book.ToString().ToLower().Contains(strBuilder.ToString().ToLower()))
                {
                    foundBooks.Add(book);
                }
            }

            return foundBooks;
        }
    }
}