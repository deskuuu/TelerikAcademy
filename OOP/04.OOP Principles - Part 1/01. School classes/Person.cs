namespace _01.School_classes
{
    using System;
    using Contracts;

    public class Person : INamable, ICommentable
    {
        private string name;
        private string comment;

        public Person(string name, string comment)
        {
            this.Name = name;
            this.Comment = comment;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null || value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Invalid name.");
                }
                this.Name = value;
            }
        }

        public string Comment
        {
            get
            {
                return comment;
            }
            set
            {
                if (value == null || value.Length < 10)
                {
                    throw new ArgumentException("Your comment must be greather than 10 symbols.");
                }
                this.Comment = value;
            }
        }
    }
}