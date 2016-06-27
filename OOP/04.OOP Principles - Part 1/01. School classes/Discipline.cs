namespace _01.School_classes
{
    using System;
    using _01.School_classes.Contracts;

    public class Discipline : IName, IComment
    {
        public int numberOfLectures { get; set; }
        public int numberOfExcercises { get; set; }

        public Discipline(string name, string comment, int numberOfLectures, int numberOfExcercises)
        {
            this.Name = name;
            this.Comment = comment;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExcercises = numberOfExcercises;
        }

        public string Comment
        {
            get
            {
                return Comment;
            }

            set
            {
                if (Comment == null || Comment.Length <= 10)
                {
                    throw new ArgumentException("Comment must be greather than 10 symbols.");
                }
                Comment = value;
            }
        }

        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                if (Name == null || Name.Length <= 3)
                {
                    throw new ArgumentException("Name must be greather than 3 alphabets");
                }
                Name = value;
            }
        }
    }
}