// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите предложение");
string text = Console.ReadLine();
string[] atext = text.Split(' ');
int length = atext.Length;
bool flag=true;
for (int i = 0; i < length; i++)
{
    if (atext[i] != atext[length-1 - i])
    {
        flag = false;
        Console.WriteLine("Предложение не палиндром");
        break;
    }
    
} 
if (flag )
Console.WriteLine("Предложение палиндром");
