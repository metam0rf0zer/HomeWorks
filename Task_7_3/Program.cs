// See https://aka.ms/new-console-template for more information


void PrintNumbers(int[] numbers, bool reverse = false)
{
    if (reverse)
    {
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }
    }
    else
    {
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
    Console.WriteLine(); 
}



    int[] numbers = { 1, 2, 3, 4, 5 };

    Console.WriteLine("Обычный порядок:");
    PrintNumbers(numbers); 

    Console.WriteLine("\nОбратный порядок:");
    PrintNumbers(numbers, reverse: true); 
