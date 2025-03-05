// See https://aka.ms/new-console-template for more information
int n = Convert.ToInt32(Console.ReadLine());
int a = n;
int cnt = 0;
while (n != 0)
{
    n = n / 10;
    cnt += 1;
}

int b = 0;
int c = Convert.ToInt32(Math.Pow(10, cnt - 1));

for (int i = 1; i <= cnt; i++)
{
    b += a % 10 * c;
    a = a / 10;
    c = c / 10;
}
Console.WriteLine(b);