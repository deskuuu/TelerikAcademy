namespace _02.Students_and_workers
{   
     using Systems;
     
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }
        
        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Grade can`t be negative");
                }
                grade = value;
            }
        }
    }
}
