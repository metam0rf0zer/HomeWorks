// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;




string pattern = @"^\+7\(\d{3}\)\d{3}-\d{2}-\d{2}$";

Regex regex = new Regex(pattern);

bool flag = false;
while (flag == false)
{
    Console.WriteLine("Введите номер телефона в формате +7(###)###-##-##");
    string number = Console.ReadLine();
    flag = regex.IsMatch(number);
    if (flag == false)
    {
        Console.WriteLine("Номер не соответствует формату");
    }
}Console.WriteLine("Номер соответствует формату");