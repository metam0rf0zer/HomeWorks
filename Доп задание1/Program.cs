namespace Доп_задание1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(1, 101);
            int attemp = 1;
            Console.WriteLine("Я загадал число от 1 до 100 включительно, попробуй угадать!");
            string answer = "";
            int result = ConvertToInt();
            if (result == num)
                Console.WriteLine("Ничего себе, угадал с 1го раза!");

            else
            {
                while (result != num)
                {
                    attemp++;
                    if (num < result)
                    {
                        Console.WriteLine("Загаданное число меньше");
                    }
                    else if (num > result)
                    {
                        Console.WriteLine("Загаданное число больше");
                    }                    
                    result = ConvertToInt();
                }
                Console.WriteLine($"Молодец! Угадал с {attemp} попытки!");
            }

        }

        public static int ConvertToInt()
        {
            while (true)
            {
                string input = Console.ReadLine();

                try
                {
                    return int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено не число. Попробуйте снова.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: число слишком большое или маленькое. Попробуйте снова.");
                }
            }
        }
    }
}