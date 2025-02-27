// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Math.Max(a, b);
int e = Math.Max(d, c);
int f = Math.Min(a, b);
int g = Math.Min(f, c);
Console.WriteLine(a + b + c - e - g);





