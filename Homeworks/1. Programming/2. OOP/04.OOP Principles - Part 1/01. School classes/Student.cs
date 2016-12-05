namespace _01.School_classes
{
    public class Student : Person
    {
        private int uniqueNumber;

        public Student(string name, string comment, int uniqueNumber) : base(name, comment)
        {
            this.UniqueNumber = uniqueNumber;
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            set
            {
                if (value < 1)
                {
                    throw new System.ArgumentException("Student number can`t be negative.");
                }
                this.UniqueNumber = value;
            }
        }
    }
}