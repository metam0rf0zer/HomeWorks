namespace Task_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal amount = 0;
            string operation = "";
            BankAccount account = new BankAccount();
            while (operation != "0")
            {
                Console.WriteLine("Что бы пополнить баланс введите 1 \nЧто бы снять сумму введите 2 \nЧто бы проверить состояние счёта введите 3 \nЧто бы выйти из программы введите 0");
                operation = Console.ReadLine();
                if (operation != "0" && operation != "1" && operation != "2" && operation != "3")
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine("Нужно вводить цифру от 0 до 3");
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine();
                    continue;
                }
                switch (operation)
                {
                    case "1":
                        {
                            account.Deposit(amount);
                            break;
                        }
                    case "2":
                        {
                            account.Withraw(amount);
                            break;
                        }
                    case "3":
                        {
                            account.PrintAcc();
                            break;
                        }






                }

            }
        }
    }
    class BankAccount
    {
        decimal _balance;
        static int TotalAccounts = 0;
        readonly int AccountNumber;

        //Конструктор
        public BankAccount()
        {
            Random r = new Random();
            AccountNumber = r.Next(1000, 10000);
            TotalAccounts++;
        }


        //Состояние счёта
        public void PrintAcc()
        {
            Console.WriteLine();
            Console.WriteLine(new string('*', 50));
            Console.WriteLine($"Аккаунт №{TotalAccounts}\nID аккаунта: {AccountNumber}\nБаланс: {_balance} р.");
            Console.WriteLine(new string('*', 50));
            Console.WriteLine();
        }

        //Метод на пополнение баланса
        //Скажите пожалуйста, если я хочу как то оборвать код то это возможно только если засунуть код в цикл или есть какая то другая возможность?))
        public decimal Deposit(decimal amount)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Введите сумму пополнения");
                try
                {
                    amount = Convert.ToDecimal(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine($"Должно быть введено число");
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine();
                    break;
                }

                string a = Convert.ToString(amount);
                if (string.IsNullOrEmpty(a))
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine("Поле не может быть пустым");
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine();
                }
                else if (string.IsNullOrWhiteSpace(a))
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine("Поле не может быть пустым");
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine();
                }
                else if (amount < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine("Число должно быть положительным");
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine();
                }
                else
                {
                    _balance += amount;
                    Console.WriteLine();
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine($"Сумма попполнения: {amount} р., текущий баланс: {_balance} р.");
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine();

                }

            }
            return _balance;

        }
        //Метод на снятие с баланса
        public decimal Withraw(decimal amount)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Введите суму снятия");                
                try
                {
                    amount = Convert.ToDecimal(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine($"Должно быть введено число");
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine();
                    break;
                }

                string a = Convert.ToString(amount);
                if (string.IsNullOrEmpty(a))
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine("Поле не может быть пустым");
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine();
                    break;
                }
                else if (string.IsNullOrWhiteSpace(a))
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine("Поле не может быть пустым");
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine();
                    break;
                }
                else if (amount < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine("Число должно быть положительным");
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine();
                    break;
                }

                
                if (_balance - amount > 0)
                {

                    _balance -= amount;
                    Console.WriteLine();
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine($"Сумма снятия:{amount} р., текущий баланс: {_balance} р.");
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine($"На балансе не достаточно средств");
                    Console.WriteLine(new string('!', 50));
                    Console.WriteLine();
                }
            }

            return _balance;

        }



    }
}



