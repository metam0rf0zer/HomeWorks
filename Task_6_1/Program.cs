// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
Console.WriteLine("Напишите предложение");
string text = Console.ReadLine();
string[] atext = text.Split(' ');
int length=atext.Length;
string word = atext[0];  
for (int i = 0; i < length; i++)
{
    if (word.Length < atext[i].Length)
    {
        word = atext[i];
    }
    
}
Console.WriteLine("Самое длинное слово в предложении - {0}",word);