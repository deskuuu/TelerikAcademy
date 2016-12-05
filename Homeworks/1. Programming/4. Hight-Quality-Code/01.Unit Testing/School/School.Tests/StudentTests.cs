namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void Student_AddStudentName_ShouldAddStudentNameCorrectly()
        {
            var student = new Student("Anna Mariq", 9777);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Student_AddANullStudentName_ShouldThrowArgumentNullException()
        {
            string name = null;

            Student student = new Student(name, 9777);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Student_AddStudentUniqueNumberOutOfRange_ShouldThrowArgumentOutOfRangeException()
        {
            var uniqueNumber = 2;

            var student = new Student("Anna Mariq", uniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Student_JoinNullCourse_ShouldThrowArgumentNullException()
        {
            var student = new Student("Anna Mariq", 7777);
            Course course = null;
            student.JoinCourse(course);
        }

        [TestMethod]
        public void Student_JoinCourse_ShouldJoinStudentCorrectly()
        {
            var student = new Student("Anna Mariq", 7777);
            var course = new Course();
            student.JoinCourse(course);

            Assert.AreEqual(1, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Student_LeaveNullCourse_ShouldThrowArgumentNullException()
        {
            var student = new Student("Anna Mariq", 7777);
            Course course = null;
            student.LeaveCourse(course);
        }

        [TestMethod]
        public void Student_LeaveCourse_ShouldLeaveStudentCorrectly()
        {
            var student = new Student("Anna Mariq", 7777);
            var course = new Course();
            student.JoinCourse(course);
            student.LeaveCourse(course);

            Assert.AreEqual(0, course.Students.Count);
        }
    }
}
