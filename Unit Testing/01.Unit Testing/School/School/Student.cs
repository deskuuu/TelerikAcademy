namespace School
{
    using System;

    public class Student
    {
        // Students should have name and unique number
        private const int MinUniuqueNumber = 10000;
        private const int MaxUniqueNumber = 99999;

        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.name = name;
            this.uniqueNumber = uniqueNumber;
        }

        // Name can not be empty and the unique number is between 10000 and 99999.
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentNullException("Name cannot be null.");
                }

                name = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return uniqueNumber;
            }

            set
            {
                if (!(value > MinUniuqueNumber && value < MaxUniqueNumber))
                {
                    throw new ArgumentOutOfRangeException("Invalid number range!");
                }

                uniqueNumber = value;
            }
        }

        public void JoinCourse(Course course)
        {
            ValidateCourse(course);

            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            ValidateCourse(course);

            course.RemoveStudent(this);
        }

        void ValidateCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("This course is missed.");
            }
        }
    }
}
