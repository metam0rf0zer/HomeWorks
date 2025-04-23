using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"(\\/)(0_0)(\\/) ПРОСТОЙ КАЛЬКУЛЯТОР (\\/)(0_0)(\\/) ");
        try
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine);
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine);


        }
    }

    static int ReadNumber(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    static void CalculateAndPrintResult(int num1, int num2, int operation)
    {
        switch (operation)
        {
            case 1:
                Console.WriteLine($"\nРезультат: {num1} + {num2} = {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($"\nРезультат: {num1} - {num2} = {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($"\nРезультат: {num1} * {num2} = {num1 * num2}");
                break;
            case 4:
                if (num2 == 0) throw new DivideByZeroException();
                Console.WriteLine($"\nРезультат: {num1} / {num2} = {(double)num1 / num2:F2}");
                break;
            default:
                Console.WriteLine("Ошибка: Неверный код операции!");
                break;
        }
    }
}