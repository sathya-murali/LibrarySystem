using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibrarySystem
{
    class Books:LibrarySystem
    {
        public string bookId;
        public List<string> BookCategories = new List<string>() { };
        public string bookCategory;
        public string bookTitle;
        public List<string> bookAuthors;

        public Books() { }
        public Books(string BookId, List<string> LibBookCategories, string BookCategory, string BookTitle, List<string> BookAuthors)
        {
            this.bookId = BookId;
            this.BookCategories = LibBookCategories;
            this.bookCategory = BookCategory;
            this.bookAuthors = BookAuthors;
            this.bookTitle = BookTitle;
        }

        public void booksDetails()
        {
            Console.WriteLine($"Id of this Book is {bookId}");
            Console.WriteLine($"Book Category is {bookCategory}");
            Console.WriteLine("Book Author are ");
            bookAuthors.ForEach(Authorslist => Console.WriteLine(Authorslist));
            Console.WriteLine($"Book Title is {bookTitle}");
        }
        public void bookCollections()
        {
            Console.WriteLine("List of All Book Categories");
            //BookCategories.ToList().ForEach(list => Console.WriteLine(list));
            BookCategories.ForEach(list => Console.WriteLine(list));
        }
        public void TrackBooks()
        {
            Console.WriteLine($"Total no of Books in Library {totalNoOfBooksInSystem}");
        }

    }
}
