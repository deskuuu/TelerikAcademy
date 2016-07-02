namespace _02.Students_and_workers
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FrstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value == null || value.Length < 5)
                {
                    throw new ArgumentException("Invalid name.");
                }
                return firstName = value;
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
                if (value == null || value.Length < 5)
                {
                    throw new ArgumentException("Invalid name.");
                }
                return lastName = value;
            }
        }
    }
}
