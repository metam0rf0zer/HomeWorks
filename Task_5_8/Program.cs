// See https://aka.ms/new-console-template for more information
const int n = 5;
int[] t = new int[n];
Random rnd = new Random();
int i = 0;
int mx = 0; int mx2 = 0;
for (i = 0; i < n; i++)
{

    t[i] = rnd.Next(0, 11);
    mx = t[i] > mx ? t[i] : mx;
    mx2 = mx2 < mx && mx2 > t[i] ? mx2 : t[i];
    Console.WriteLine(t[i]);
}
Console.WriteLine("самое большое число {0}, второе по велечине число {1}", mx, mx2);