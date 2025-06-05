namespace Task_15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var warehouse=new Dictionary<string, int>();
            warehouse.Add("A001", 10);
            warehouse.Add("B205", 25);
            warehouse.Add("C307", 15);
            //Проверяю наличие товара
            bool inList = warehouse.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом B205? {inList}");
            //Обновляю количество ноутбуков
            warehouse["A001"] = 8;
            //Полуаю количество наушников
            if (warehouse.TryGetValue("C307", out int headphoneCount))
            {
                Console.WriteLine($"Количество наушников: {headphoneCount} шт.");
            }
            //Увеличиваю количество смартфонов
            warehouse["B205"] = warehouse["B205"] + 5;
            //Удаляю наушники со склада
            warehouse.Remove("C307");
            //Вывожу инвентарь
            Console.WriteLine("Текущий инвентарь:");
            foreach (var item in warehouse)
            {
                Console.WriteLine($"Артикул: {item.Key} Количество: {item.Value}");
            }
            //Проверяю инвентарь
            if (warehouse.Count() > 0)
            {
                bool isEmpty=false;
                Console.WriteLine($"Инвентарь пуст? {isEmpty}");
            }
            //Удаляю все товары
            warehouse.Clear();
            Console.WriteLine($"Количество товаров после очистки: {warehouse.Count()}");
        }
    }
}
