namespace _04.Person_class
{
    using System;

    public class Person
    {
        //Create a class Person with two fields – name and age.Age can be left unspecified(may contain null 
        //value.Override ToString() to display the information of a person and if age is not specified – to say so.
        private string name;
        private int age;

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.Age = age;
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
                    throw new ArgumentException("You must have name!");
                }
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
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("You can` have negative age number.");
                }

                age = value;
            }
        }

        public override string ToString()
        {
            if (age != 0)
            {
                return $"Name: {name} \nAge: {age}";
            }
            else
            {
                return "No!";
            }
        }
    }
}
