namespace _01.Student_class
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student : ICloneable, IComparable
    {
        //Define a class Student, which contains data about a student – first, 
        //middle and last name, SSN, permanent address, mobile phone e-mail, 
        //course, specialty, university, faculty.Use an enumeration for the specialties, universities and faculties.
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanenetAddress;
        private string phoneNumber;
        private string email;
        private string course;

        public string PermanenetAddress { get; private set; }
        public SpecialityType Speciality { get; private set; }
        public UniversityType University { get; private set; }
        public FacultyType Faculty { get; private set; }

        public Student(string firstName, string middleName, string lastName, string ssn, string address, string phoneNumber,
            string email, string course, SpecialityType speciality, UniversityType university, FacultyType faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.permanenetAddress = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Speciality = speciality;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                ChackNameException(value);
                firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                ChackNameException(value);
                middleName = value;
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
                ChackNameException(value);
                lastName = value;
            }
        }

        public string SSN
        {
            get
            {
                return ssn;
            }

            set
            {
                ChackNumberException(value);
                ssn = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                ChackNumberException(value);
                phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (!Regex.IsMatch(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    throw new NullReferenceException("Invalid e-mail.");
                }

                email = value;
            }
        }

        public string Course
        {
            get
            {
                return course;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Invalid course.");
                }

                course = value;
            }
        }

        private void ChackNumberException(string ssn)
        {
            foreach (var ch in ssn)
            {
                if (!Char.IsDigit(ch))
                {
                    throw new ArgumentException("Invalid number.It must be only of digits.");
                }
            }
        }

        private void ChackNameException(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Your name can`t be empty.");
            }
        }

        //  Equals(), ToString(), GetHashCode() and operators == and !=.
        public override bool Equals(object obj)
        {
            return this == obj as Student;
        }

        public override string ToString()
        {
            var information = new StringBuilder();
            information.AppendLine("Student information");
            information.AppendLine("-------------------------------------");
            information.AppendLine($"Full name: {firstName} {middleName} {lastName}");
            information.AppendLine($"SS number: {ssn}");
            information.AppendLine($"Permanent address: {permanenetAddress}");
            information.AppendLine($"Phone number: {phoneNumber}");
            information.AppendLine($"Emai: {email}");
            information.AppendLine($"University: {University}");
            information.AppendLine($"Faculty: {Faculty}");
            information.AppendLine($"Speciality: {Speciality}");
            information.AppendLine($"Course: {course}");

            return information.ToString();
        }

        public override int GetHashCode()
        {
            var sSN = ssn.GetHashCode();
            int code = base.GetHashCode();
            code *= sSN;
            return code;
        }

        public object Clone()
        {
            return new Student(this.firstName, this.middleName, this.lastName, this.ssn, this.permanenetAddress, this.phoneNumber,
                this.email, this.course, this.Speciality, this.University, this.Faculty);
        }

        public int CompareTo(Student another)
        {
            var output = -1;
            if (this.firstName.Length > another.firstName.Length && this.ssn.Length < another.ssn.Length)
            {
                return 1;
            }

            return output;
        }

        public static bool operator ==(Student first, Student second)
        {
            var isTheSamePerson = false;

            if (first.ssn == second.ssn)
            {
                isTheSamePerson = true;
            }

            return isTheSamePerson;
        }

        public static bool operator !=(Student first, Student second)
        {
            var isTheSamePerson = true;

            if (first.ssn != second.ssn)
            {
                isTheSamePerson = false;
            }

            return isTheSamePerson;
        }
    }
}
