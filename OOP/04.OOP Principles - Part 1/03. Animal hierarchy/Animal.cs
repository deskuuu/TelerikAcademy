namespace _3.Animal_hierarchy
{
    using _3.Animal_hierarchy.Contracts;

    public abstract class Animal : ISound
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public SexType Sex { get; }

        public Animal(int age, string name, SexType sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public abstract string MakeSound();
    }
}
