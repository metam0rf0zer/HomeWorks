// See https://aka.ms/new-console-template for more information
int g = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int s = Convert.ToInt32(Console.ReadLine());
double r = g + m / 60.0 + s / 3600.0;
double d = r * ( Math.PI/180);
Console.WriteLine(d);