// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите месяц");
string month=Console.ReadLine();

Console.WriteLine("Введите год");
string year = Console.ReadLine();

Console.WriteLine("Введите общую сумму продаж");
double total = Convert.ToDouble(Console.ReadLine());
string totals=Convert.ToString(total);
totals = String.Format("{0:N2}", total);

Console.WriteLine("Введите количество проданых товаров");
double count = Convert.ToDouble(Console.ReadLine());
string counts = Convert.ToString(count);
counts = String.Format("{0:0,0}", count);



double mid= total/count;
string mids=Convert.ToString(mid);
mids=String.Format("{0:N2}", mid);


Console.WriteLine("-------------------");
Console.WriteLine("Отчёт о продажах за {0} {1}", month, year);
Console.WriteLine("-------------------");
Console.WriteLine("Общая сумма продаж {0} р.",totals);
Console.WriteLine("Количество проданных товаров: {0} шт.", counts);
Console.WriteLine("Средняя стоимость товара: {0} р.", mids);
Console.WriteLine("-------------------");



