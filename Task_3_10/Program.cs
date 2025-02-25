// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int n=Convert.ToInt32(Console.ReadLine());
if (n == 1 || (n % 10 == 1&&n>20))
{
    Console.WriteLine("Мы построили {0} дом", n);
}
else if (n >= 2 && n <= 4 || ((n % 10 >= 2 && n % 10 <= 4)&&n>20))
{
    Console.WriteLine("Мы построили {0} дома", n);
}
else
{
    Console.WriteLine("Мы построили {0} домов", n);
}