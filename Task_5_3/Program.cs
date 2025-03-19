// See https://aka.ms/new-console-template for more information
using System.Security.Claims;

const int n = 10;
int[] t = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    t[i] = rnd.Next(0, 51);
    Console.WriteLine(t[i]);
}
int max = t[0];
int min = t[0];
int index_max = 0;
int index_min = 0;
for (int j = 0; j < 10; j++)
{
    if ( t[j]>max)
    {
        max = t[j];
        index_max = j;
    }

}
for (int j = 0; j < 10; j++)
{
    if (t[j] < min)
    {
        min = t[j];
        index_min = j;
    }

}
Console.WriteLine("{0} - максимальное число, его индекс {1}", max,index_max);
Console.WriteLine("{0} - минимальное число, его индекс {1}", min,index_min);