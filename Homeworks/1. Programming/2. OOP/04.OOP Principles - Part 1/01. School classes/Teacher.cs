namespace _01.School_classes
{
    using _01.School_classes.Contracts;
    using System.Collections.Generic;

    public class Teacher : Person
    {
        public Teacher(string name, string comment) : base(name, comment)
        {
        }

        public ICollection<Discipline> Disciplines { get; set; }
    }
}