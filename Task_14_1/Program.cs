namespace Task_14_1
{
    internal class Program
    {
        delegate int Transformer(int number);        
        static void Main(string[] args)
        {
            int[] numbers = { -6, -4, 0, 3, 5 };

            Console.WriteLine("Оригинальный массив");
            PrintArray(numbers);

            Console.WriteLine("Умноженые на 2");
            int[] doubled = Transform(numbers, DoubleNumber);
            PrintArray(doubled);

            Console.WriteLine("В квадрате");
            int[] sqwared = Transform(numbers, SqwareNumber);
            PrintArray(sqwared);

            Console.WriteLine("По модулю");
            int[] absed = Transform(numbers, AbsNumber);
            PrintArray(absed);

        }
        //Метод выводящий массив
        public static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        //Метод принимающий массив и делегат
        static int[] Transform(int[] array, Transformer transformer)
        {
            if (array == null || transformer == null)
                throw new ArgumentNullException();
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = transformer(array[i]);
            }
            return result;

        }

        //Метод умножение на 2
        static int DoubleNumber(int number)
        {
            return number * 2;
        }
        //Метод возведения в квадрат
        static int SqwareNumber(int number)
        {
            return number * number;
        }
        //Метод модуль числа
        static int AbsNumber(int number)
        {
            return Math.Abs(number );
        }
    }

}

