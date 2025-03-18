// See https://aka.ms/new-console-template for more information
double n = Convert.ToInt32(Console.ReadLine());
while (n > 1)
{
    n = n / 2;
    if (n * 10 % 10 != 0)
    {
        Console.WriteLine("NO");
        break;
    }
    if (n == 1)
    {
        Console.WriteLine("YES");
    }
}

