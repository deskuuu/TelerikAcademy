namespace School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private ICollection<Course> courses;
        private ICollection<Student> students;
        private string name;

        public School(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course should have name.");
                }

                name = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("You should add a student name.");
            }

            if (students.Contains(student))
            {
                throw new NullReferenceException("Student have been there.");
            }

            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("You should add a student name.");
            }

            if (!students.Contains(student))
            {
                throw new NullReferenceException("Student already leaved the course.");
            }

            students.Remove(student);
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course should has a name.");
            }

            if (courses.Contains(course))
            {
                throw new ArgumentNullException("This course has been added.");
            }

            courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course should has name.");
            }

            if (!courses.Contains(course))
            {
                throw new InvalidOperationException("This course already missed.");
            }

            courses.Remove(course);
        }
    }
}
