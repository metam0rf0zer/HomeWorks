using System;

namespace Task_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ValidateAge(Convert.ToInt32(Console.ReadLine()));
            }
            catch (FormatException)
            {
                Console.WriteLine($"Введено не число");
            }

            catch (ArgumentOutOfRangeException)
            {
               Console.WriteLine($"Возраст слишком большой");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Возраст не может быть отрицательным");
            }
            finally
            {
                Console.ReadLine();
            }

        }

        static void ValidateAge(int age)
        {
            if (age < 0)
                throw new ArgumentException();

            if (age > 150) 
                throw new ArgumentOutOfRangeException();                  
                                 
        }
    }
}
