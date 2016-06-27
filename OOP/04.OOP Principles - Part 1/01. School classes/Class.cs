namespace _01.School_classes
{
    using Contracts;
    using System.Collections.Generic;

    public class Class : IName, IComment
    {
        public ICollection<Student> Students { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

        public string Name { get; set; }
        public string Comment { get; set; }

        public Class(string name)
        {
            this.Name = name;
        }
    }
}