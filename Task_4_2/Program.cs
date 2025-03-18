// See https://aka.ms/new-console-template for more information
double n = Convert.ToInt32(Console.ReadLine());
double total = 0;
double i = 1;
for (i = 1; i <= n; i++)
{
    total += 1 / i;
}
Console.WriteLine(total);