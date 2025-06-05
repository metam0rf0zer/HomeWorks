using System.Buffers;
using System.Security.Principal;

namespace Банковский_счёт
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(666, "Симон", 1500);
            account.PrintInfo();

            account.Deposit(1000);
            account.Withdraw(300);

            account.PrintInfo();
        }
        class BankAccount
        {
            public int AccountNumber { get; set; }
            public string Owner { get; set; }
            public decimal Balance { get; set; }

            public BankAccount(int accountNumber, string owner, decimal balance)
            {
                AccountNumber = accountNumber;
                Owner = owner;
                Balance = balance ;
            }
            public decimal Deposit(decimal amount)
            {
                if (amount < 0)
                {
                    throw new ArgumentException("Сумма должна быть положительной");

                }
                 Balance += amount;
                return Balance;

            }
            public decimal Withdraw(decimal amount)
            {
                if (amount < 0)
                {
                    throw new ArgumentException("Сумма должна быть положительной");

                }
                Balance -= amount;
                return Balance;

            }
            public void GetBalance()
            {
                Console.WriteLine(Balance);
            }
            public void PrintInfo()
            {
                Console.WriteLine($"Владелец:{Owner} \nНомер счёта:{AccountNumber} \nБаланс: {Balance} руб.");
            }
        }
    }
}