namespace _3.Animal_hierarchy.Animals
{
    using _3.Animal_hierarchy.Contracts;

    public class Dog : Animal
    {
        public Dog(int age, string name, SexType sex) : base(age, name, sex)
        {
        }

        public override string MakeSound()
        {
            return string.Format("Bau-bau!!!");
        }
    }
}
