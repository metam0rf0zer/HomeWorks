using System.ComponentModel;
using System.Reflection;

namespace Task_12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book<string, int>[] books1 = new Book<string, int>[]
            {
                new Book<string, int>("F - 1234", 2020, "Война и мир", "Лев Толстой"),
                new Book<string, int>("42", 2021, "Преступление и наказание", "Фёдор Достоевский")
            };
            Book<int, string>[] books2 = new Book<int, string>[]
            {
                new Book<int, string>(1234, "2020", "Война и мир", "Лев Толстой"),
                new Book<int, string>(42, "2021", "Преступление и наказание", "Фёдор Достоевский")
            };

            var book1 = FindBook(books1, "F - 1234");
            Console.WriteLine(book1?.ToString()??"Книга отсутствует");

            var book2 = FindBook(books2, 42);
            Console.WriteLine(book2?.ToString() ?? "Книга отсутствует");

        }
        
        static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (Book<T, U> book in books)
            {
                if (book.Code.Equals(code))
                    return book;
            }
            return null;
        }
    }
    public class Book<T, U>
    {
        public T Code { get; set; }
        public U PublicationYear { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(T code, U publicationYear, string title, string author)
        {
            this.Code = code;
            this.PublicationYear = publicationYear;
            this.Title = title;
            this.Author = author;
        }
        public override string ToString()
            => $"Код: {Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
    }
}

