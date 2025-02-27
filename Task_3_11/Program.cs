// See https://aka.ms/new-console-template for more information
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int p = Convert.ToInt32(Console.ReadLine());
int q = Convert.ToInt32(Console.ReadLine());
int r = Convert.ToInt32(Console.ReadLine());
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Может ли участок {0}X{1} вместить в себя дома размером {2}X{3} и {4}X{5}?", a, b, p, q, r, s);
if ((q + s <= a) && (p + r <= b))
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}

