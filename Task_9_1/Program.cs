using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Task_9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            for (int i = 0; i < 1; i++)
            {
                //Отлавливаю исключения в названии книги
                try
                {
                    Console.WriteLine("Введите название книги");
                    book.Title = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }


                //Отлавливаю исключения в имени автора
                try
                {
                    Console.WriteLine("Введите имя автора в формате #. ######## (например Л. Толстой)");
                    book.Author = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }


                //Отлавливаю исключения в дате издания
                Console.WriteLine("Введите дату издания от 0 до 2025");                
                try
                {
                    book.Year = SetYear(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                

                //Отлавливаю исключения в количестве страниц
                Console.WriteLine("Введите количество страниц");                
                try
                {
                    book.Pages = SetPages(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }                 
                book.Getinfo();
            }

        }
        //Метод для проверки года издания
        static string SetYear(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                throw new ArgumentNullException(paramName: null, message: "Дата не может быть пустой");
            }
            else if (!int.TryParse(a, out int year))
            {
                throw new FormatException(message: "Значение должно быть числом");
            }
            else if (year < 0 || year > 2025)
            {
                throw new ArgumentOutOfRangeException(paramName: null, message: "Значение вне диапазона");
            }
            else
            {
                return a;
            }

        }
        //Метод для проверки ввода количества страниц
        static string SetPages(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                throw new ArgumentNullException(paramName: null, message: "Дата не может быть пустой");
            }
            else if (!int.TryParse(a, out int pages))
            {
                throw new FormatException(message: "Значение должно быть числом");
            }
            else
            {
                return a;               
            }
           

        }


    }
    class Book
    {
        string _title;
        string _author;
        public string Year { get; set; }
        public string Pages { get; set; }

        public string Title
        {
            set
            {
                Regex regex = new Regex(@"^[A-ZА-ЯЁ0-9].*$");
                if (regex.IsMatch(value))
                {
                    _title = value;
                }
                else if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(paramName: null, message: "Название книги не может быть пустым");
                }
                else
                {
                    throw new FormatException(message: "Название книги должно начинаться с заглавной буквы");
                }
            }
            get
            {
                return _title;
            }
        }

        public string Author
        {
            set
            {
                Regex regex = new Regex(@"^[А-ЯЁ]\.\s[А-ЯЁ][а-яё]+$");
                if (regex.IsMatch(value))
                {
                    _author = value;
                }
                else if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(paramName: null, message: "Имя автора не может быть пустым");
                }
                else if (regex.IsMatch(value) == false)
                {
                    throw new FormatException("Имя автора не соответствует формату");
                }
            }
            get
            {
                return _author;
            }
        }
        public void Getinfo()
        {
            Console.WriteLine($"{Title}, {Author}, {Year}, {Pages} стр.");
        }
    }
}
