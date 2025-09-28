namespace API_Task_1_1
{
    internal class Changed_class
    {
        static void Main(string[] args)
        {
            
        }
        public class NewShoppingCartService
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
