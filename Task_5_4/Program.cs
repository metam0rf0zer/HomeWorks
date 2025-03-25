// See https://aka.ms/new-console-template for more information
const int n = 10;
int[] t = new int[n];
Random rnd = new Random();
int i = 0;
for (i = 0; i < n; i++)
{
    t[i] = rnd.Next(0, 10);
    Console.WriteLine(t[i]);
}


Console.WriteLine();
Console.WriteLine();

for (i = 0; i < 5; i++)
{
    int a = t[i];
    t[i] = t[9-i];
    t[9-i] = a;
    Console.WriteLine(t[i]);
}
for (i = 5; i < 10; i++)
{
    Console.WriteLine(t[i]);
}