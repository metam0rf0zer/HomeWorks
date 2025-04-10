namespace Task_9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();      
            
            book.Title = "Война и мир";
            book.Author = "Л.Толстой";

            book.Getinfo();

        }





    }
    class Book
    {
        string _title;
        string _author;
        int Year;
        int Pages;

        public string Title
        {
            set
            {
                this._title = value;
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
                this._author = value;
            }
            get
            {
                return _author;
            }
        }



        public void Getinfo()
        {
            Console.WriteLine($"{Title},{_author},{Year},{Pages} стр.");
        }

            
        

       





    }


}
