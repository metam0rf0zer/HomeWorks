namespace Task_15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаю список фамилий
            List<string> listTeam = new List<string>();
            listTeam.Add("Иванов");
            listTeam.Add("Петров");
            listTeam.Add("Сидоров");
            

            //Добавляю фамилию по индексу
            listTeam.Insert(1, "Козлов");
            //Проверяю наличие фамилии            
            bool inList = listTeam.Contains("Петров");
            Console.WriteLine($"Есть ли игрок 'Петров' в команде? {inList}");
            //Удаляю фамилию из списка
            listTeam.Remove("Сидоров");
            //Ищу индекс по фамилии
            int index=listTeam.IndexOf("Козлов");
            Console.WriteLine($"Индекс игрока 'Козлов': {index}");
            //Сортирую фамилии по алфавиту
            listTeam.Sort();
            //Вывожу получившийся список
            Console.WriteLine("Текущий состав команды:");
            for (int i = 0; i < listTeam.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{listTeam[i]}");
            }
            //Проверка на наличие
            bool isEmpty = true;
            if (listTeam.Count != 0)
            {
                isEmpty = false;
            }
            Console.WriteLine($"Команда пуста? {isEmpty}");
            
            
            listTeam.Clear();
            Console.WriteLine($"Количество игроков после очистки: {listTeam.Count}");
            
        }
    }
}
