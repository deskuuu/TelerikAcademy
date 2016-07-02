namespace _02.Bank_accounts.Accounts
{
    using System;

    using Contracts;

    public class Deposit : Account, IDrawable
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int mounth)
        {
            //Deposit accounts have no interest if their balance is positive and less than 1000.
            if (Balance > 0 || Balance < 1000)
            {
                return mounth * InterestRate;
            }

            return 0;
        }

        public void Draw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentException("Balance shoul be greather than amount.");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Deposit: {Customer.Name}\nBalance: {Balance}";
        }
    }
}
