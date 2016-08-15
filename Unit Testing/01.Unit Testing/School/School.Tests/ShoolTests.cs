namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ShoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateNullSchool_ShouldThrowArgumentNullException()
        {
            string name = null;

            var school = new School(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullStudent_AddANullStudentInShool_ShouldThrowArgumentNullException()
        {
            var school = new School("HR.Smirnenski");
            Student student = null;
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddTheSameStudent_AddTheSameStudentInShool_ShouldThrowNullException()
        {
            var school = new School("HR.Smirnenski");
            Student student = new Student("Anna MAriq", 9);
            school.AddStudent(student);
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveNullStudent_RemoveANullStudentFromShool_ShouldThrowArgumentNullException()
        {
            var school = new School("HR.Smirnenski");
            Student student = null;
            school.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoveMissedStudent_RemoveMissedStudentStudentFromShool_ShouldThrowNullException()
        {
            var school = new School("HR.Smirnenski");
            var student = new Student("Anna Mariq", 9);
            school.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullCourse_AddANullCourseInShool_ShouldThrowArgumentNullException()
        {
            var school = new School("HR.Smirnenski");
            Course course = null;
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddTheSameCourse_AddTheSameCourseInShool_ShouldThrowNullException()
        {
            var school = new School("HR.Smirnenski");
            var course = new Course();
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveNullCourse_RemoveNullCourseFromShool_ShouldThrowArgumentNullException()
        {
            var school = new School("HR.Smirnenski");
            Course course = null;
            school.AddCourse(course);
            school.RemoveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoveMissedCourse_RemoveMissedCourseFromShool_ShouldThrowNullException()
        {
            var school = new School("HR.Smirnenski");
            var course = new Course();
            school.RemoveCourse(course);
        }
    }
}
