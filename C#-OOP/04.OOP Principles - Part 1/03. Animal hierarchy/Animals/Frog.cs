namespace _3.Animal_hierarchy.Animals
{
    public class Frog : Animal
    {
        public Frog(int age, string name, SexType sex) : base(age, name, sex)
        {
        }

        public override string MakeSound()
        {
            return string.Format("Frog-frog..!!!");
        }
    }
}