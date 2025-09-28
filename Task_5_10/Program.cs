// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;

const int n = 3;
int[,] array = new int[n, n];
Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(0, 2);
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}
for (int g = 0; g < 1; g++)
{
    //Проверка по основной диагонали
    bool flag = false;
    int cnt = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cnt = i == j && array[i, j] == 1 ? cnt + 1 : cnt;
        }
        flag = cnt == 3 ? true : false;

    }
    if (flag == true)
    {
        Console.WriteLine("Крестики выйграли диагональ");
        break;
    }


    //Проверка по побочной диагонали
    flag = false;
    cnt = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cnt = array[j, i] == 1 && i + j == n - 1 ? cnt + 1 : cnt;
        }
        flag = cnt == 3 ? true : false;

    }
    if (flag == true)
    {
        Console.WriteLine("Крестики выйграли побочная диагональ");
        break;
    }


    //Проверка по горизонтали
    flag = false;

    for (int i = 0; i < n; i++)
    {
        cnt = 0;
        for (int j = 0; j < n; j++)
        {
            if (j < 2 && array[i, 0] == 1)
            {
                cnt = array[i, j] == array[i, j + 1] && array[i, j] == 1 ? cnt + 1 : cnt;
            }
        }

        flag = cnt == 2 ? true : false;
        if (flag == true)
        {
            break;
        }

    }
    if (flag == true)
    {
        Console.WriteLine("Крестики выйграли Горизонталь");
        break;
    }


    //Проверка по вертикали
    flag = false;
    cnt = 0;
    int x = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i, x] == 1)
        {
            cnt = cnt + 1;
        }
        else
        {
            cnt = 0;
        }
        for (int j = 0; j < n; j++)
        {
            if (array[i, j] == 1)
            {
                x = j;
            }
            flag = cnt == 2 ? true : false;
            if (flag == true)
            {
                Console.WriteLine("Крестики выйграли Вертикаль");
                break;
            }
            

        }
        

    }
    if (flag == false)
    {
        Console.WriteLine("Креситики проиграли");
    }

}




 