namespace Employee_Data.Models
{
    using System;
    using System.Text;

    using Contracts;
    using Types;

    public class Employee : IEmployee
    {
        private string firstName;
        private string lastName;
        private int age;
        private string employeeNumber;

        public Employee(string firstName, string lastName, int age, GenderType gender, string employeeNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this.EmployeeNumber = employeeNumber;
        }

        public GenderType Gender { get; set; }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.Validate(value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.Validate(value);
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative!");
                }

                this.age = value;
            }
        }

        public string EmployeeNumber
        {
            get
            {
                return this.employeeNumber;
            }

            set
            {
                this.Validate(value);

                this.employeeNumber = value;
            }
        }

        private void Validate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Missing input data");
            }
        }

        public override string ToString()
        {
            var stb = new StringBuilder();

            stb.AppendLine($"First name: {this.FirstName}");
            stb.AppendLine($"Last name: {this.LastName}");
            stb.AppendLine($"Age: {this.Age}");
            stb.AppendLine($"Gender: {this.Gender}");
            stb.AppendLine($"Employee Number: {this.EmployeeNumber}");

            return stb.ToString();
        }
    }
}
