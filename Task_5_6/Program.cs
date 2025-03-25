// See https://aka.ms/new-console-template for more information
const int n = 5;
int[,] array = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {

        array[i, j] = (i + j) %2==0 ? 1 : 0 ;
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}
Console.ReadKey(); 