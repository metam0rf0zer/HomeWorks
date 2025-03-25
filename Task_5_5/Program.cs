// See https://aka.ms/new-console-template for more information
const int n = 10;
int[] t = new int[n];
Random rnd = new Random();
int i = 0;
for (i = 0; i < n; i++)
{
    t[i] = rnd.Next(-50, 51);
    Console.WriteLine(t[i]);
}


Console.WriteLine();
Console.WriteLine();

for (i = 0; i < 5; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (t[i] > t[j])
        {
            int a = t[i];
            t[i] = t[j];
            t[j] = a;
        }      
    }
    Console.WriteLine(t[i]);
}

for (i = 5; i < 10; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (t[i] < t[j])
        {
            int a = t[i];
            t[i] = t[j];
            t[j] = a;
        }
    }
    Console.WriteLine(t[i]);
}