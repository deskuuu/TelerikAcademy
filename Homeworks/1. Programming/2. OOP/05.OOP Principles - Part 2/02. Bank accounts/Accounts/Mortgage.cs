namespace _02.Bank_accounts.Accounts
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int mounth)
        {
            //Mortgage accounts have ½ interest 
            //for the first 12 months for companies and no interest for the first 6 months for individuals.
            var mount = mounth;

            if (Customer is Individual)
            {
                mounth = mounth - 6;

            }
            else if (Customer is Company)
            {
                mounth = (mount - 12) / 2;
            }

            return mounth * InterestRate;
        }

        public override string ToString()
        {
            return $"Mortgage: {Customer.Name}\nBalance: {Balance}";
        }
    }
}
