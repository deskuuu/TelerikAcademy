/*Problem 11. BankAccountData
Print a bank acount data.
*/
namespace _11.Bank_Account_Data
{
    using System;

    class BankAccountData
    {
        static void Main()
        {
            Console.WriteLine("Enter an employees first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter an employees middle name: ");
            string middleName = Console.ReadLine();
            Console.WriteLine("Enter an employees lastName: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter an available amount of money: ");
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter an employees bank name: ");
            string bankName = Console.ReadLine();
            Console.WriteLine("Enter an employees IBAN: ");
            string iban = Console.ReadLine();
            Console.WriteLine("Enter an employees first credit card number: ");
            string firstCreditCard = Console.ReadLine();
            Console.WriteLine("Enter an employees second credit card number: ");
            string secondCreditCard = Console.ReadLine();
            Console.WriteLine("Enter an employees third credit card number: ");
            string thirdCreditCard = Console.ReadLine();

            PrintEmployeeInformation(firstName, middleName, lastName, amountOfMoney, bankName, iban, firstCreditCard, secondCreditCard, thirdCreditCard);
        }

        static void PrintEmployeeInformation(string firstName, string middleName, string lastName,
           decimal amountOfMoney, string bankName, string iban, string firstCreditCard,
           string secondCreditCard, string thirdCreditCard)
        {
            if (string.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(middleName) || string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("Invalid or missing first, last or middle employees name.");
            }

            if (amountOfMoney < 50.0m)
            {
                throw new ArgumentOutOfRangeException("Invalid amount of money.Can`t be smaller than $50.00.");
            }

            if (string.IsNullOrEmpty(bankName))
            {
                throw new ArgumentNullException("Imployye must has a bank account name!");
            }

            if (string.IsNullOrEmpty(iban))
            {
                throw new ArgumentNullException("Employye must has IBAN number!");
            }

            if (string.IsNullOrEmpty(firstCreditCard) || string.IsNullOrEmpty(secondCreditCard) || string.IsNullOrEmpty(thirdCreditCard))
            {
                throw new ArgumentNullException("Employye must has three credit bank cards!");
            }

            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Employee`s information: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine($@"
            First name => {firstName}
            Middle name => {middleName}
            Last name => {lastName}
            Amount of money => {amountOfMoney}
            Bank name => {bankName}
            IBAN => {iban}
            First credit card number => {firstCreditCard}
            Second credit card number => {secondCreditCard}
            Third credit card number => {thirdCreditCard}
            ");
        }
    }
}
