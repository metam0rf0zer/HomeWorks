// See https://aka.ms/new-console-template for more information
const int n = 10;
int[] t = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    t[i] = rnd.Next(0, 10);
    Console.WriteLine(t[i]);
}
Console.WriteLine(t);