/*Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/

using System;

    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleName;
            string lastName;
            decimal balance;
            string bankName;
            string ibn;
            ulong firstCreditCard;
            ulong secondCreditCard;
            ulong thirdCreditCard;
            
            firstName = "Desi";
            middleName = "At";
            lastName = "Manova";
            balance = 5000;
            bankName = "UniCredit";
            ibn = "Uni85634";
            firstCreditCard = 100;
            secondCreditCard = 2456;
            thirdCreditCard = 8000;
            
            // the result
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}",firstName,middleName,lastName,balance,bankName,ibn,firstCreditCard,secondCreditCard,thirdCreditCard);
        }
    }

