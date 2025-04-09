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
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }

        static void ValidateAge(int age)
        {
            if (age < 0)
                throw new ArgumentException(paramName: null, message:$"Возраст не может быть отрицательным");

            if (age > 150)
                throw new ArgumentOutOfRangeException(paramName: null, message: $"Возраст слишком большой");

        }
    }
}
