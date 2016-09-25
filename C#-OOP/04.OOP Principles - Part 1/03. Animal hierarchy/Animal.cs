namespace _3.Animal_hierarchy
{
    using _3.Animal_hierarchy.Contracts;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private SexType sex;

        public Animal(int age, string name, SexType sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
        
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid age.");
                }
                age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Invalid name.");
                }
                name = value;
            }
        }
        
        public SexType Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }
        
        public abstract string MakeSound();
    }
}
