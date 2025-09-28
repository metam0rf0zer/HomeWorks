namespace API_Task_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new ShoppingCartService();

            Console.WriteLine("=== Тест 1: Regular клиент с 3 товарами ===");
            var prices1 = new List<decimal> { 1000, 2000, 3000 };
            var total1 = service.CalculateTotalPrice("Regular", prices1);
            Console.WriteLine($"Итоговая цена: {total1}\n");

            Console.WriteLine("=== Тест 2: Premium клиент с суммой > 1000 скидки ===");
            var prices2 = new List<decimal> { 5000, 6000, 7000 }; // Общая сумма = 18000, скидка 15% = 2700 → >1000 → 1000 + 1700*0.1 = 1170
            var total2 = service.CalculateTotalPrice("Premium", prices2);
            Console.WriteLine($"Итоговая цена: {total2}\n");

            Console.WriteLine("=== Тест 3: VIP клиент с 2 товарами ===");
            var prices3 = new List<decimal> { 2500, 3500 };
            var total3 = service.CalculateTotalPrice("VIP", prices3);
            Console.WriteLine($"Итоговая цена: {total3}\n");

            Console.WriteLine("=== Тест 4: Premium клиент с суммой скидки < 1000 ===");
            var prices4 = new List<decimal> { 1000, 2000 }; // Общая сумма = 3000, скидка 15% = 450 → <1000 → остаётся 450
            var total4 = service.CalculateTotalPrice("Premium", prices4);
            Console.WriteLine($"Итоговая цена: {total4}\n");

            Console.WriteLine("=== Тест 5: Неизвестный тип клиента (без скидки) ===");
            var prices5 = new List<decimal> { 1000, 1000 };
            var total5 = service.CalculateTotalPrice("Unknown", prices5);
            Console.WriteLine($"Итоговая цена: {total5}\n");

            Console.WriteLine("=== Тест 6: CalculateTotalPriceWithQuantities (Premium) ===");
            var itemsDict = new Dictionary<decimal, int>
            {
                { 1000m, 3 }, // 3 шт по 1000
                { 500m, 2 }   // 2 шт по 500
            };
            var total6 = service.CalculateTotalPriceWithQuantities("Premium", itemsDict);
            Console.WriteLine($"Итоговая цена: {total6}\n");

            Console.WriteLine("=== Тест 7: CalculateTotalPriceWithQuantities (VIP) ===");
            var itemsDict2 = new Dictionary<decimal, int>
            {
                { 2000m, 2 },
                { 1500m, 1 }
            };
            var total7 = service.CalculateTotalPriceWithQuantities("VIP", itemsDict2);
            Console.WriteLine($"Итоговая цена: {total7}\n");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
        public class ShoppingCartService
        {
            public decimal CalculateTotalPrice(string customerType, List<decimal> itemPrices)
            {
                decimal baseTotal = 0;
                for (int i = 0; i < itemPrices.Count; i++)
                {
                    baseTotal += itemPrices[i];
                }

                decimal discount = 0;

                if (customerType == "Regular")
                {
                    discount = baseTotal * 0.05m; // 5%
                }
                else if (customerType == "Premium") //Нарушение принципа YAGNI Тип покупателя Premium сейчас не требуется
                {
                    discount = baseTotal * 0.15m; // 15%
                    if (discount > 1000)
                    {
                        discount = 1000 + (discount - 1000) * 0.1m;
                    }
                }
                else if (customerType == "VIP")  //Нарушение принципа YAGNI Тип покупателя VIP сейчас не требуется
                {
                    discount = baseTotal * 0.20m; // 20%
                }

                decimal finalPrice = baseTotal - discount;

                Console.WriteLine($"Base: {baseTotal}, Discount: {discount}, Final: {finalPrice}");
                return finalPrice;
            }

            public decimal CalculateTotalPriceWithQuantities(string customerType, Dictionary<decimal, int> itemsWithQuantities)
            {
                List<decimal> allPrices = new List<decimal>();
                foreach (var item in itemsWithQuantities)
                {
                    for (int i = 0; i < item.Value; i++)
                    {
                        allPrices.Add(item.Key);
                    }
                }
                return CalculateTotalPrice(customerType, allPrices);
            }
        }
    }
}
