namespace _02.Bank_accounts
{
    using Accounts;
    using System;

    class Test
    {
        static void Main()
        {
            // create bank
            var bank = new Bank("DSK");
            // add some accounts
            bank.AddAccount(new Deposit(new Individual("Anna"), 3000, 780));
            bank.AddAccount(new Loan(new Company("System 442"), 1289, 560));
            bank.AddAccount(new Mortgage(new Individual("Stessy"), 3211, 250));
            //  print bank information
            Console.WriteLine(bank);
        }
    }
}
