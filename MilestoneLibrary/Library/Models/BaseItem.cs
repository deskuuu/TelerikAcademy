namespace Library.Models
{
    using System;

    using Library.Common;
    using Library.Common.Contracts;

    public abstract class BaseItem : IBaseItem
    {
        private string title;
        private string isbn;

        public BaseItem(string title)
        {
            this.title = title;
            this.isbn = this.GenerateRandomIsbn();
        }

        private string GenerateRandomIsbn()
        {
            return DateTime.UtcNow.Ticks.ToString().Substring(8);
        }

        public string Title
        {
            get => this.title;
            set => this.title = Validator.ValidateData(title, Constants.MinItemLength, Constants.InvalidFieldMessage);
        }

        public string Isbn
        {
            get => this.isbn;
            set => this.isbn = Validator.ValidateData(isbn, Constants.MinIsbnLength, Constants.InvalidFieldMessage);
        }

        public abstract void DownloadItem();
    }
}
