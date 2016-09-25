namespace _03.First_before_last
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (firstName == null || firstName.Length < 4)
                {
                    throw new ArgumentException("Invalid or missing name.");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (lastName == null || lastName.Length < 4)
                {
                    throw new ArgumentException("Invalid or missing name.");
                }
                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(age<1)
                {
                    throw new ArgumentException("Invalid age number.");
                }
                age = value;
            }
        }

        public override string ToString()
        {
            return string.Format($"{firstName} {lastName} {age}");
        }
    }
}

