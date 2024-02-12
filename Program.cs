using System;

namespace bookStore
{
    class Book
    {
        private int _id;
        private string _title;
        private string _author;
        private static int _transactions = 0;

        public Book()
        {
            _id = 0;
            _title = "";
            _author = "";
        }

        public Book(int id, string title, string author)
        {
            _id = id;
            _title = title;
            _author = author;
        }

        public int getId()
        {
            return _id;
        }
        public string getTitle()
        {
            return _title;
        }
        public string getAuthor()
        {
            return _author;
        }
        public static int getTransactions()
        {
            return _transactions;
        }
        public void setId(int id)
        {
            _id = id;
        }
        public void setTitle(string title)
        {
            _title = title;
        }
        public void setAuthor(string author)
        {
            _author = author;
        }
        public void setTransactions() 
        { 
            _transactions++; 
        }
    }

    class myStore
    {
        static void Main(string[] args)
        {
            Book book01 = new Book();
            book01.setId(1);
            book01.setTitle("A Treatise of Human Nature");
            book01.setAuthor("David Hume");
            book01.setTransactions();

            Book book02 = new Book();
            Console.WriteLine("Please enter the book ID");
            book02.setId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book's title");
            book02.setTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book's Author");
            book02.setAuthor(Console.ReadLine());
            book02.setTransactions();

            Book book03 = new Book(3, "A Critique of Pure Reason", "Immanuel Kant");
            book03.setTransactions();

            Console.WriteLine("Please enter the book ID");
            int newId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book's title");
            string newTitle = Console.ReadLine();
            Console.WriteLine("Please enter the book's Author");
            string newAuthor = Console.ReadLine();
            Book book04 = new Book(newId, newTitle, newAuthor);
            book04.setTransactions();

            Console.WriteLine($"Transactions = {Book.getTransactions()}");

            displayBooks(book01);
            displayBooks(book02);
            displayBooks(book03);
            displayBooks(book04);
        }

        static void displayBooks(Book book)
        {
            Console.WriteLine();
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"book ID: {book.getId()}");
            Console.WriteLine($"book title: {book.getTitle()}");
            Console.WriteLine($"book author: {book.getAuthor()}");
        }
    }
}