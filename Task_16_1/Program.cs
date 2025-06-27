namespace Task_16_1
{
    internal class Program
    {
        class Computer
        {
            public int Code { get; set; }
            public string Brand { get; set; }
            public string CpuType { get; set; }
            public double CpuFrequency { get; set; } // ГГц
            public int RamSize { get; set; } // ГБ
            public string HardDriveCapacity { get; set; }
            public int GpuMemory { get; set; } // ГБ
            public double Price { get; set; } // усл. ед.
            public int InStock { get; set; }

            public override string ToString()
            {
                return $"Код: {Code}, Марка: {Brand}, Процессор: {CpuType} ({CpuFrequency} ГГц), " +
                       $"ОЗУ: {RamSize} ГБ, ЖД: {HardDriveCapacity}, Видео: {GpuMemory} ГБ, " +
                       $"Цена: {Price}, В наличии: {InStock} шт.";
            }
        }

        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>
            {
                new Computer() { Code = 101, Brand = "Dell", CpuType = "Intel Core i5-12400F", CpuFrequency = 2.5, RamSize = 8, HardDriveCapacity = "512 ГБ SSD", GpuMemory = 4, Price = 750, InStock = 15 },
                new Computer() { Code = 102, Brand = "HP", CpuType = "AMD Ryzen 7 5800X", CpuFrequency = 3.8, RamSize = 16, HardDriveCapacity = "1 ТБ HDD + 256 ГБ SSD", GpuMemory = 8, Price = 1100, InStock = 7 },
                new Computer() { Code = 103, Brand = "Lenovo", CpuType = "Intel Core i3-12100", CpuFrequency = 3.4, RamSize = 32, HardDriveCapacity = "1 ТБ SSD", GpuMemory = 16, Price = 1500, InStock = 4 },
                new Computer() { Code = 104, Brand = "ASUS", CpuType = "AMD Ryzen 5 5600G", CpuFrequency = 3.9, RamSize = 16, HardDriveCapacity = "512 ГБ SSD", GpuMemory = 4, Price = 900, InStock = 10 },
                new Computer() { Code = 105, Brand = "Acer", CpuType = "Intel Core i3-12100", CpuFrequency = 3.3, RamSize = 8, HardDriveCapacity = "256 ГБ SSD", GpuMemory = 2, Price = 550, InStock = 20 },
                new Computer() { Code = 106, Brand = "MSI", CpuType = "AMD Ryzen 9 5900X", CpuFrequency = 3.7, RamSize = 64, HardDriveCapacity = "2 ТБ SSD", GpuMemory = 16, Price = 2000, InStock = 2 },
                new Computer() { Code = 107, Brand = "Apple", CpuType = "Apple M1 Pro", CpuFrequency = 3.2, RamSize = 16, HardDriveCapacity = "1 ТБ SSD", GpuMemory = 16, Price = 2200, InStock = 35 }
            };

            foreach (var comp in computers)
            {
                Console.WriteLine(comp);
            }

            Console.WriteLine(new string('=', 150));

            Console.WriteLine("Укажите название процессора");


            string cpu = Console.ReadLine();
            //Ищем по названию процессора
            List<Computer> cpuList = computers
                .Where(c => c.CpuType == cpu)
                .ToList();
            //Вывод найденых позиций
            foreach (var comp in cpuList)
            {
                Console.WriteLine(comp);
            }

            Console.WriteLine(new string('=', 150));

            Console.WriteLine("Укажите минимальный объём ОЗУ");
            int ram = Convert.ToInt32(Console.ReadLine());

            //Ищем по минимальному объёму памяти
            List<Computer> ramList = computers
                .Where(r => r.RamSize > ram)
                .ToList();

            //Вывод найденых позиций
            foreach (var comp in ramList)
            {
                Console.WriteLine(comp);
            }
            Console.WriteLine(new string('=', 150));



            //Выводим список отсортированный по стоимости
            Console.WriteLine("ОТСОРТИРОВАННЫЙ ПО СТОИМОСТИ СПИСОК");
            List<Computer> sortPriceList = computers
                .OrderBy(p => p.Price)
                .ToList();

            foreach (var comp in sortPriceList)
            {
                Console.WriteLine(comp);
            }

            // Группируем список по типу процессора
            var groupCpuTypeList = computers
                .GroupBy(g => g.CpuType);

            Console.WriteLine("СГРУППИРОВАННЫЙ ПО ТИПУ ПРОЦЕССОРА СПИСОК");
            Console.WriteLine(new string('=', 80));

            foreach (var group in groupCpuTypeList)
            {
                Console.WriteLine($"ТИП ПРОЦЕССОРА: {group.Key}");
                Console.WriteLine(new string('-', 80));

                foreach (var comp in group)
                {
                    Console.WriteLine($"Код: {comp.Code}, Марка: {comp.Brand}, ОЗУ: {comp.RamSize} ГБ, " +
                                      $"ЖД: {comp.HardDriveCapacity}, Видео: {comp.GpuMemory} ГБ, " +
                                      $"Цена: {comp.Price}, В наличии: {comp.InStock} шт.");
                }

                Console.WriteLine(new string('=', 80));
            }

            //Находим самый дешёвый ПК
            Console.WriteLine("Самый дешёвый ПК");
            var cheapestPc = computers
               .OrderBy(g => g.Price)
               .FirstOrDefault();

            if (cheapestPc != null)
            {
                Console.WriteLine($"Код: {cheapestPc.Code}, Марка: {cheapestPc.Brand}, Процессор: {cheapestPc.CpuType}, " +
                                  $"Цена: {cheapestPc.Price}, ОЗУ: {cheapestPc.RamSize} ГБ, В наличии: {cheapestPc.InStock} шт.");
            }
            else
            {
                Console.WriteLine("Список компьютеров пуст.");
            }

            Console.WriteLine(new string('=', 150));


            //Находим самый дорогой ПК
            Console.WriteLine("Самый дорогой ПК");
            var expensivePc = computers
               .OrderByDescending(g => g.Price)
               .FirstOrDefault();

            if (expensivePc != null)
            {
                Console.WriteLine($"Код: {expensivePc.Code}, Марка: {expensivePc.Brand}, Процессор: {expensivePc.CpuType}, " +
                                  $"Цена: {expensivePc.Price}, ОЗУ: {expensivePc.RamSize} ГБ, В наличии: {expensivePc.InStock} шт.");
            }
            else
            {
                Console.WriteLine("Список компьютеров пуст.");
            }

            Console.WriteLine(new string('=', 150));

            //Выясняю есть ли хотя бы один ПК в количестве 30шт.
            bool has30PC = computers
                .Any(d => d.InStock > 30);
            Console.WriteLine($"Есть ли больше 30 компьютеров одной комплектации на складе?: {has30PC}");
        }
    }
}
