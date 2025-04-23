using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"(\\/)(0_0)(\\/) ПРОСТОЙ КАЛЬКУЛЯТОР (\\/)(0_0)(\\/) ");

        try
        {
            int num1 = ReadNumber("Введите первое число: ");
            int num2 = ReadNumber("Введите второе число: ");

            Console.WriteLine("\nДоступные операции:");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Вычитание (-)");
            Console.WriteLine("3. Умножение (*)");
            Console.WriteLine("4. Деление (/)");

            int operation = ReadNumber("Выберите операцию (1-4): ");

            CalculateAndPrintResult(num1, num2, operation);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введено не число!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: Деление на ноль невозможно!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
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