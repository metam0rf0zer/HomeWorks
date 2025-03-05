// See https://aka.ms/new-console-template for more information
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
int pow = 1;
for (; i <= b; i++)
{
    pow *= a;
}
Console.WriteLine(pow);