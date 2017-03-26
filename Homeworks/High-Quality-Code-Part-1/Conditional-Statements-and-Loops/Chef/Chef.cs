namespace Chef
{
    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = GetBowl();
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            //... 
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private Potato GetPotato()
        {
            //...
        }

        private void Peel(Vegetable vegetable)
        {
            // ...
        }

        private void Cut(Vegetable vegetable)
        {
            //...
        }
    }
}
