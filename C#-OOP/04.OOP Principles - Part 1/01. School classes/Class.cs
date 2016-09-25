namespace _01.School_classes
{
    using Contracts;
    using System.Collections.Generic;

    public class Class : INamable, ICommentable
    {
        public ICollection<Student> Students { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

        private string name;
        private string comment;

        public Class(string name)
        {
            this.Name = name;
        }
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null || value.Length < 7)
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
                    throw new ArgumentException("Comment must be greather than 10 symbols.");
                }
                this.Comment = value;
            }
        }
    }
}