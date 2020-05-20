using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    class Initialize
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Main Method from Initialize Class");
            List<string> categories = new List<string> 
            {
                "Kids",
                "Computer Books",
                "Fiction Books"
            };
            List<string> bookAuthors = new List<string>
            {
                "Hobbins",
                "Bilbo"
            };
            Books books = new Books("KD1456", categories, "Kids", "Little Stars", bookAuthors);
            books.booksDetails();
            books.TrackBooks();
            List<string> libraryComputers = new List<string>()
            {
                "DESKTOP-FLR1-001",
                "DESKTOP-FLR1-002"
            };
            List<string> libraryPrinters = new List<string>()
            {
                "PRINT-FLR1-001",
                "PRINT-FLR1-002"
            };

            List<string> libraryCds = new List<string>()
            {
                "He-Man Master of Universe",
                "Pokemon"
            };

            LibrarySystem libSys = new LibrarySystem();
            libSys.Peripherals(libraryComputers, libraryPrinters, libraryCds);
            
            Employee employee = new Employee();
            employee.totalNoOfBooksInSystem = 1250;

            PublicLibrarian librarian = new PublicLibrarian();
            librarian.getAllPrinterStatus();
            librarian.getAllComputerStatus();
            List<string> returnedBooks = new List<string>
            {
                "KD3456",
                "CB0987",
                "FIC4589"
            };
            librarian.getReturnedBooks(returnedBooks);


        }
    }

    
}
