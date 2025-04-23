namespace Task_7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            int b=Convert.ToInt32(Console.ReadLine());
            int result=Multiply(a,b);
            Console.WriteLine("{0}*{1}={2}", a, b, result);


            Console.WriteLine("Введите первое дробное число");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе дробное число");
            double d = Convert.ToDouble(Console.ReadLine());
            double result2 = Multiply(c, d);

            Console.WriteLine("{0}*{1}={2}",c,d,result2);


        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }
    }

}
