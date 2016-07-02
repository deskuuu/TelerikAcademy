namespace _02.Bank_accounts.Accounts
{
    using System;

    public abstract class Account
    {
        //All accounts have customer, balance and interest rate(monthly based).
        private Customer customer;

        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;

        }

        public Customer Customer
        {
            get
            {
                return customer;
            }

            private set
            {
                customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid balance, can`t be negative.");
                }

                balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }

            set
            {
                if (interestRate < 100)
                {
                    throw new ArgumentException("Invalid interest rate, it can`t be less than 100.");
                }

                interestRate = value;
            }
        }

        public abstract decimal CalculateInterest(int mounth);

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("You cannot deposit negative amount of money.");
            }

            Balance += amount;
        }
    }
}