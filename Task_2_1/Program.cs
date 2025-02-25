// See https://aka.ms/new-console-template for more information
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int t = c;
c = b;
b = a;
a = t;
Console.WriteLine("{0} {1} {2}", a, b, c);
