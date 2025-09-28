// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Введите имя");
string name=Console.ReadLine();


Console.WriteLine("Введите возраст");
string age = Console.ReadLine();

Console.WriteLine("Введите город");
string city = Console.ReadLine();

StringBuilder sb = new StringBuilder();
sb.Append("Имя: ");
sb.Append(name);
sb.Append(", Возраст: ");
sb.Append(age);
sb.Append(", Город: ");
sb.Append(city);
Console.WriteLine(sb.ToString());