using System.Diagnostics;

namespace Task_17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Тестирование через ContinueWith:");
            TestWithContinueWith();

            Console.WriteLine("\nТестирование через async/await:");
            TestWithAsyncAwait().Wait(); // Ждём завершения async метода

            Console.WriteLine("\nРабота программы завершена.");
            Console.ReadKey();
        }

        public static int[] ArrayCreator()
        {
            var rnd = new Random();
            var array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Массив создан");
            return array;
        }
        public static double Average(int[] array)
        {
            double average = array.Average();
            Thread.Sleep(1000);
            Console.WriteLine($"Среднее арифметическое: {average}");
            return average;
        }
        // Тестирование через ContinueWith
        private static void TestWithContinueWith()
        {
            Stopwatch sw = Stopwatch.StartNew();

            Task<int[]> generateTask = Task.Run(() => ArrayCreator());

            generateTask.ContinueWith(prevTask =>
            {
                int[] array = prevTask.Result;
                Average(array);
                sw.Stop();
                Console.WriteLine($"Время выполнения (ContinueWith): {sw.Elapsed.TotalSeconds:F2} секунд");
            });
        }

        // Тестирование через async/await
        private static async Task TestWithAsyncAwait()
        {
            Stopwatch sw = Stopwatch.StartNew();

            int[] array = await Task.Run(() => ArrayCreator());
            double average = await Task.Run(() => Average(array));

            sw.Stop();
            Console.WriteLine($"Время выполнения (async/await): {sw.Elapsed.TotalSeconds:F2} секунд");
        }
    }
}
