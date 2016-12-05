namespace _09.Student_groupss
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        //    Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks(a List), GroupNumber.
        private string firstName;
        private string lastName;
        private string fn;
        private string tel;
        private string email;
        private int groupNumber;

        private IList<int> marks;

        public Student(string firstName, string lastName, string fn, string tel,
            string email, List<int> marks, int groupNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fn = fn;
            this.tel = tel;
            this.email = email;
            this.marks = new List<int>();
            this.groupNumber = groupNumber;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                Checked(firstName);
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                Checked(lastName);
                lastName = value;
            }
        }

        public string FN
        {
            get { return fn; }
            set
            {
                Checked(fn);
                fn = value;
            }
        }

        public string Tel
        {
            get { return tel; }
            set
            {
                Checked(tel);
                tel = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                Checked(email);
                email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return new List<int>(marks);
            }
            set
            {
                marks = new List<int>(value);
            }
        }

        public int GroupNumber
        {
            get { return groupNumber; }
            set
            {
                if (groupNumber < 2)
                {
                    throw new ArgumentException("Invalid group number.");
                }
                groupNumber = value;
            }
        }

        private void Checked(string textToCheck)
        {
            if (textToCheck == null || textToCheck.Length <= 0)
            {
                throw new ArgumentException("Invalid parameter.");
            }
        }
    }
}
