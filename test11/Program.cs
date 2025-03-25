// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;

const int n = 3;
int[,] array = { { 0, 0, 1 }, { 0, 0, 1 }, { 0,0 , 1 } };

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}






//Проверка по вертикали
bool flag = false;
int cnt = 0;
int x = 0;
for (int i = 0; i < n; i++)
{
    if (array[i,x]==1)
    {
        cnt=cnt+1;
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
            break;
        }
    }
    if (flag==true)
    {
        break;
    }

}
Console.WriteLine(flag);






