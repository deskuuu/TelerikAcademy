namespace _02.Bank_accounts
{
    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value == null || value.Length < 4)
                {
                    throw new System.ArgumentNullException("It must have a custumer.");
                }
            }
        }
    }
}