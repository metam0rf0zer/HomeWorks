// See https://aka.ms/new-console-template for more information
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число оканчивается на 0?");
if (n % 10 == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
Console.WriteLine("Число чётное?");
if (n % 2 == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
Console.WriteLine("Число двузначное?");
if ((-100 < n && n <= -10) || (100 > n && n >= 10))
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
Console.WriteLine("Число в диапазоне [-10,10]?");
if (-10 <= n && n <= 10)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
Console.WriteLine("Число в диапазоне (-∞,-10]U[10,+∞)?");
if (n>=-10&&n<=10)
{
    Console.WriteLine("НЕТ");
}
else
{
    Console.WriteLine("ДА");
}