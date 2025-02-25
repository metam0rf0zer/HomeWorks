// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введbnt число от в диапазоне [100,999]");
int n = Convert.ToInt32(Console.ReadLine());
string a = "";
string b = "";
string c = "";
if (n < 100 || n > 1000)
{
    Console.WriteLine("Введённое число не удовлетворяет условиям");
}

if (n / 100 == 1)
{
    c = "Сто";
}
else if (n / 100 == 2)
{
    c = "Двести";
}
else if (n / 100 == 3)
{
    c = "Триста";
}
else if (n / 100 == 4)
{
    c = "Четыреста";
}
else if (n / 100 == 5)
{
    c = "Пятьсот";
}
else if (n / 100 == 6)
{
    c = "Шестьсот";
}
else if (n / 100 == 7)
{
    c = "Семьсот";
}
else if (n / 100 == 8)
{
    c = "Восемьсот";
}
else if (n / 100 == 9)
{
    c = "Девятьсот";
}


if (n / 100%10 == 2&&)


if (n % 10 == 1)
{
    a = "один";
}
else if (n % 10 == 2)
{
    a = "два";
}
else if (n % 10 == 3)
{
    a = "три";
}
else if (n % 10 == 4)
{
    a = "четыре";
}
else if (n % 10 == 5)
{
    a = "пять";
}
else if (n % 10 == 6)
{
    a = "шесть";
}
else if (n % 10 == 7)
{
    a = "семь";
}
else if (n % 10 == 8)
{
    a = "восемь";
}
else if (n % 10 == 9)
{
    a = "девять";
}
if (n / 10 % 10 == 1)
