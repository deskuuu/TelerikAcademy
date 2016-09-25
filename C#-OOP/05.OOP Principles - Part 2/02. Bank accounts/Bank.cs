namespace _02.Bank_accounts
{
    using System;
    using System.Collections.Generic;

    using Accounts;

    public class Bank
    {
        private string name;
        private List<Account> accounts;

        public Bank(string name)
        {
            this.Name = name;
            accounts = new List<Account>();
        }

        public Account this[int index]
        {
            get
            {
                return this.accounts[index];
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null || value.Length < 3)
                {
                    throw new NullReferenceException("Name must be greather than 3 simbols and can`t be ampty.");
                }

                name = value;
            }
        }

        public List<Account> Accounts
        {
            get
            {
                return this.accounts;
            }

            set
            {
                this.accounts = value;
            }
        }

        public void AddAccount(Account accoun)
        {
            this.accounts.Add(accoun);
        }

        public void RemoveAccount(Account accoun)
        {
            this.accounts.Remove(accoun);
        }

        public override string ToString()
        {

            foreach (var acc in accounts)
            {
                Console.WriteLine(acc.ToString());
            }
            return $"Bank information:\nBank name: {Name}";
        }
    }
}
