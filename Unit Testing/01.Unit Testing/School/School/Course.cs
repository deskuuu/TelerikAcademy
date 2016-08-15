namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxStudentsInCourse = 30;

        // Each course contains a set of students.
        private IList<Student> students;

        public Course()
        {
            this.students = new List<Student>();
        }

        // Students in a course should be less than 30 and can join and leave courses.
        public IList<Student> Students
        {
            get
            {
                return students;
            }

            set
            {
                if (students.Count > MaxStudentsInCourse)
                {
                    throw new ArgumentOutOfRangeException("Students at one course must be less than 30.");
                }

                students = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student should have name.");
            }

            if (students.Contains(student))
            {
                throw new InvalidOperationException("This student has been in the course.");
            }

            if (students.Count + 1 > MaxStudentsInCourse)
            {
                throw new ArgumentOutOfRangeException("The course is full.");
            }

            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student should has a name.");
            }

            if (!students.Contains(student))
            {
                throw new InvalidOperationException("This student is missed.");
            }

            students.Remove(student);
        }
    }
}
