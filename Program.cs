using System;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;

        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        public int GetId()
        {
            return _Id;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        public string GetAuthor()
        {
            return _Author;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.SetId(1);
            book1.SetTitle("adventures of life");
            book1.SetAuthor("yousef decide");


            book book2 = new book();
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the author: ");
            book2.SetAuthor(Console.ReadLine());


            book book3 = new book(3, "into the unknown", "jack ralish");


            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author: ");
            string tempAuthor = Console.ReadLine();
            book book4 = new book(tempID, tempTitle, tempAuthor);


            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }

        static void displayBooks(book book)
        {
            Console.WriteLine("Here's your book information:");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Title: {book.GetTitle()}");
            Console.WriteLine($"Author: {book.GetAuthor()}");
        }
    }
}
