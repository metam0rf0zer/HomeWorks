using System.Reflection.Metadata;

namespace Task_15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаю коллецкию, добавляю адреса
            var subscribers = new HashSet<string>();
            subscribers.Add("alice@example.com");
            subscribers.Add("bob@example.com");
            subscribers.Add("charlie@example.com");
            //Пробую добавить дубликат
            bool addedDuplicate = subscribers.Add("alice@example.com");
            Console.WriteLine($"Дубликат alice@example.com добавлен? {addedDuplicate}");
            //Проверяю наличие подписчиков в системе
            bool inList = subscribers.Contains("bob@example.com");
            Console.WriteLine($"Есть ли в подписчиках alice@example.com? {inList}");
            inList = subscribers.Contains("dave@example.com");
            Console.WriteLine($"Есть ли в подписчиках dave@example.com? {inList}");
            //Создаю новое множество
            var newSubscribers = new HashSet<string>();
            newSubscribers.Add("bob@example.com");
            newSubscribers.Add("dave@example.com");
            newSubscribers.Add("eve@example.com");
            //Объединение множеств
            var allSubscribers = new HashSet<string>(subscribers);
            allSubscribers.UnionWith(newSubscribers);
            Console.WriteLine($"Список подписчиков после объединения:");
            foreach (string sub in allSubscribers)
            {
                Console.WriteLine($"- {sub}");
            }
            //Ищу пересечения в двух множествах
            var crossSubscribers = new HashSet<string>(subscribers);
            crossSubscribers.IntersectWith(newSubscribers);
            Console.WriteLine("Общие подписчики");
            foreach (string sub in crossSubscribers)
            {
                Console.WriteLine($"- {sub}");
            }
            //Удаляю подписчика
            inList = subscribers.Remove("charlie@example.com");
            Console.WriteLine($"Удалён ли charlie@example.com из подписчиков? {inList}");
            //Выясняю сколько всего подписчиков?
            int countSubscribers =allSubscribers.Count;
            Console.WriteLine($"Всего подписчиков: {countSubscribers}");
            //Создаю новое множество и проверяю является ли оно подмножеством allSubscribers
            var testGroup=new HashSet<string> { "bob@example.com", "eve@example.com" };            
            Console.WriteLine($"testGroup является подмножеством? {testGroup.IsSubsetOf(allSubscribers)}");
            //Очищаю коллекцию
            allSubscribers.Clear();
            Console.WriteLine($"Количество подписчиков после очистки: {allSubscribers.Count}");













        }
    }
}
