namespace _02.Bank_accounts.Accounts
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int mounth)
        {
            //Loan accounts have no interest for the first 3 months if 
            //are held by individuals and for the first 2 months if are held by a company.
            var mount = mounth;

            if (Customer is Individual)
            {
                mounth = mounth - 3;

            }
            else if (Customer is Company)
            {
                mounth = mount - 2;
            }

            return mounth * InterestRate;
        }

        public override string ToString()
        {
            return $"Loan: {Customer.Name}\nBalance: {Balance}";
        }
    }
}
