const int n = 3;
int[,] array = { { 0, 0, 0 }, { 1, 1, 1 }, { 0, 0, 0 } };

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}




//Проверка по горизонтали
bool flag = false;
int cnt = 0;
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
Console.WriteLine(flag);


