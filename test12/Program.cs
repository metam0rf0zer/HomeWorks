namespace Test12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double a=Convert.ToDouble(Console.ReadLine());
           double b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Multiply(a,b));

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
