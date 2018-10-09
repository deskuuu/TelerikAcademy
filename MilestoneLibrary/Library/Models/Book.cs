namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Library.Common;
    using Library.Common.Contracts;
    //using Library.Common.Enums;
    using Library.Common.Exceptions;

    public class Book : BaseItem, IBook
    {
        private IList<String> authors;
        private string publisher;
      //  private PublisherType publisher;
        private int publicationYear;
        private int pagesCount;

        public Book(string title, IList<string> authors, string publisher, int publicationYear, int pagesCount) : base(title)
        {
            this.authors = authors;
            this.publisher = publisher;
            this.publicationYear = publicationYear;
            this.pagesCount = pagesCount;
        }

        public IList<String> Authors
        {
            get => this.authors;
            set => this.authors = authors.Count < 1 ? throw new InvalidFieldException() : authors;
        }

      //  public PublisherType Publisher => this.publisher;

        public int PublicationYear => this.publicationYear;

        public int PagesCount
        {
            get => this.pagesCount;
            set => this.pagesCount = pagesCount < Constants.MinBookPages ? throw new InvalidFieldException() : pagesCount;
        }

        public override void DownloadItem()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Title: {this.Title}");
            stringBuilder.AppendLine($"Authurs: {String.Concat(this.authors.ToString(),',')}");
            stringBuilder.AppendLine($"Publisher: {this.publisher}");
            stringBuilder.AppendLine($"Publication year: {this.publicationYear}");
            stringBuilder.AppendLine($"Pages: {this.pagesCount}");

            return stringBuilder.ToString();
        }
    }
}