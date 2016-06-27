namespace _01.School_classes
{
    using _01.School_classes.Contracts;

    public class Person : IName, IComment
    {
        public string Name { get; set; }
        public string Comment { get; set; }

        public Person(string name, string comment)
        {
            this.Name = name;
            this.Comment = comment;
        }
    }
}