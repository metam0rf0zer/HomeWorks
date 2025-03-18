// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;

int n = Convert.ToInt32(Console.ReadLine());
int a = n;
int cnt = 0;
while (n != 0)
{
    n = n / 10;
    cnt += 1;
}
Console.WriteLine("В числе {0} {1} цифры", a, cnt);

