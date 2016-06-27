namespace _01.School_classes
{
    public class Student : Person
    {
        public int UniqueNumber { get; set; }

        public Student(string name, string comment, int uniqueNumber) : base(name, comment)
        {
            this.UniqueNumber = uniqueNumber;
        }

    }
}