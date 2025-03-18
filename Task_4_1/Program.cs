// See https://aka.ms/new-console-template for more information
double n = Convert.ToInt32(Console.ReadLine());
double total = 1;
double i = 1;
for (i = 1; i <= n; i++)
{
    total *=i;
}
Console.WriteLine(total);