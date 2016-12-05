namespace _3.Animal_hierarchy.Animals
{
    public class Cat : Animal
    {
        public Cat(int age, string name, SexType sex) : base(age, name, sex)
        {
        }

        public override string MakeSound()
        {
            return string.Format("Myau, myau!!");
        }
    }
}
