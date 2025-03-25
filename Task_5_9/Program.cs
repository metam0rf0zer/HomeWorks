// See https://aka.ms/new-console-template for more information
const int n = 6;
const int m = 6;
int[,] array = new int[n, m];

for (int i = 1; i < n; i++)
{
    for (int j = 1; j < n; j++)
    {
        array[i, j] = i == 1 ? j : array[i, j];
        array[i, j] = i > 1 ? i + n+m - 1 : array[i, j];
        array[i, j] = i == n-1 ? n : array[i, j];


        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}
Console.ReadKey();