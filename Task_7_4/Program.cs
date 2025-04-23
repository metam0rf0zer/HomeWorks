// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество чисел в массиве");
int n=Convert.ToInt32(Console.ReadLine());
int[] array=new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите {0}-е число", i+1);
    array[i]= Convert.ToInt32(Console.ReadLine());    
}

static int FindMax(params int[] numbers)
{
    return numbers.Max();
}


int maxNum=FindMax(array);
Console.WriteLine($"Max number: {maxNum}");