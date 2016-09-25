namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Students_AddOneMoreShouldOutTheCourseCapacity_ShouldThrowArgumentOutOfRangeException()
        {
            var course = new Course();
            string name = string.Empty;
            int uniqueNumber = 0;

            for (int i = 1; i <= 31; i++)
            {
                name = "Name " + i;
                uniqueNumber = i;
                Student student = new Student(name, uniqueNumber);
                course.AddStudent(student);
            }
        
        }

        [TestMethod]
        public void AddStudent_AddANewStudentInCourse_ShouldAddStudentCorrectly()
        {
            var course = new Course();
            var student = new Student("Anna Mariq", 9);
            course.AddStudent(student);

            Assert.AreSame(student, course.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullStudent_AddANullStudentInCourse_ShouldThrowArgumentNullException()
        {
            Student student = null;
            Course course = new Course();
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddTheSameStudent_AddTheSameStudentInCourse_ShouldThrowInvalidOperationException()
        {
            var student = new Student("Telerik", 9);
            Course course = new Course();
            course.AddStudent(student);
            course.AddStudent(student);
        }
    
        [TestMethod]
        public void RemoveStudent_RemoveANewStudentInCourse_ShouldRemoveStudentCorrectly()
        {
            var course = new Course();
            var student = new Student("Anna Mariq", 9);
            course.AddStudent(student);
            course.RemoveStudent(student);

            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveNullStudent_RemoveANullStudentFromCourse_ShouldThrowArgumentNullException()
        {
            Student student = null;
            Course course = new Course();
            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void MissedStudent_RemoveMissedStudentFromCourse_ShouldThrowInalisOperationException()
        {
            var missedStudent = new Student("Anna Mariq", 9);
            Course course = new Course();
            course.RemoveStudent(missedStudent);
        }
    }
}
