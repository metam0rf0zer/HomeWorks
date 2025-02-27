// See https://aka.ms/new-console-template for more information
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 100 % 10*100;
int b = n %10;
int c = n - a - b + b*100+a/100;
Console.WriteLine(c);


