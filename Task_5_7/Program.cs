// See https://aka.ms/new-console-template for more information
const int n = 10;
const int m = 5;

int[,] array = new int[n, m];
Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    int mx = 0;
    for (int j = 0; j < m; j++)
    {
        array[i, j] =  rnd.Next(0,11);
        Console.Write("{0,3} ", array[i, j]);
        mx= array[i,j] > mx ? array[i,j] : mx;
    }
    Console.WriteLine("  Самое большое число в строке {0}",mx);
}
Console.ReadKey();
 