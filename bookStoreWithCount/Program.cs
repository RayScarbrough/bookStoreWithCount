using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            //1st book
            book firstBook = new book();
            firstBook.SetTrans();
            firstBook.SetId(5);
            firstBook.SetAuthor("Lois Lowry");
            firstBook.SetTitle("The Giver");

            //2nd book
            book secondBook = new book();
            secondBook.SetTrans();

            Console.WriteLine("What is the first books id number?");
            secondBook.SetId(int.Parse(Console.ReadLine()));

            Console.WriteLine("Who is the first books Author?");
            secondBook.SetAuthor(Console.ReadLine());

            Console.WriteLine("What is the title of the first book?");
            secondBook.SetTitle(Console.ReadLine());

            //3rd book
            book thirdBook = new book(3, "Takehiko Inoue", "Vagabond");
            thirdBook.SetTrans();

            //4th book
            Console.WriteLine("Enter the second books ID");
            int tempId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second books Author");
            string tempAuthor = Console.ReadLine();

            Console.WriteLine("Enter the second books Title");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("");

            //fourth book
            book fourthBook = new book(tempId, tempAuthor, tempTitle);
            fourthBook.SetTrans();

            Console.WriteLine($"The store has {book.GetTrans()} books");
            Console.WriteLine("");

            displayBooks(firstBook);
            Console.WriteLine("");

            displayBooks(secondBook);
            Console.WriteLine("");

            displayBooks(thirdBook);
            Console.WriteLine("");

            displayBooks(fourthBook);
            Console.WriteLine("");

        }
        static void displayBooks(book book)
        {
            Console.WriteLine("Here is your books information");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Book Author: {book.GetAuthor()}");
            Console.WriteLine($"Book Title: {book.GetTitle()}");
        }
    }


    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;
        

        // Default constructor
        public book()
        {
        }

        // Parameterized constructor
        public book(int Id, string Title, string Author)
        {
            _Id = Id;
            _Title = Title;
            _Author = Author;
        }

        // Get and Set method for _Id
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int Id)
        {
            _Id = Id;
        }

        // Get and Set method for _Title
        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string Title)
        {
            _Title = Title;
        }

        // Get and Set method for _Author
        public string GetAuthor()
        {
            return _Author;
        }

        public void SetAuthor(string Author)
        {
            _Author = Author;
        }

        public void SetTrans()
        {
            _transactions++;
        }

        public static int GetTrans()
        {
            return _transactions;
        }
    }
}