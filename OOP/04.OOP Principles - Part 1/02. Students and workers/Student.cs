﻿namespace _02.Students_and_workers
{
    public class Student : Human
    {
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
