// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число от 20 до 60 включительно");
int n=Convert.ToInt32(Console.ReadLine());
while (n > 60 || n < 20)
{
    Console.WriteLine("Число не в диапазоне");
    Console.WriteLine("Введите число от 20 до 60 включительно");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("МОЛОДЕЦ!!!");
