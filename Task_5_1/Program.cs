// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

const int n = 10;
int[] t = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    t[i] = rnd.Next(0, 101);
    Console.WriteLine(t[i]);
}
int cnt_e = 0;
int cnt_ne = 0;
foreach (int i in t)
{
    int _ = i % 2 == 0 ? cnt_e++ : cnt_ne++;
}
if (cnt_e > cnt_ne)
{
    Console.WriteLine("Чётных чисел больше");
}
else if (cnt_e < cnt_ne)
{
    Console.WriteLine("Нечётных чисел больше");
} 
else Console.WriteLine("Чётных и нечётных чисел одинаковое количество");





