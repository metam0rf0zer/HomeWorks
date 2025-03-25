// See https://aka.ms/new-console-template for more information
const int n = 10;
int[] t = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    t[i] = rnd.Next(-20, 21);
    Console.WriteLine(t[i]);
}
int cnt_p = 0;
int cnt_n = 0;
foreach (int i in t)
{
    int _ = i > 0 ? cnt_p++ : cnt_n++;
}
if (cnt_p > cnt_n)
{
    Console.WriteLine("Положительных чисел больше");
}
else if (cnt_p < cnt_n)
{
    Console.WriteLine("Отрицательных чисел больше");
}
else Console.WriteLine("Положительных и отрицательных чисел одинаковое количество");
 