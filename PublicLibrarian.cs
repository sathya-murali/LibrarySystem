using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    class PublicLibrarian:Employee
    {
        public string doResearch;
        public string getBooks;
        public Dictionary<string,string> kidsEvents;
        public string printerStatus = "online";
        public string computerStatus = "offline";
        public List<string> returnedBooks = new List<string> { };

        public string getAllPrinterStatus()
        {
            if(printerStatus == "offline")
            {
                isPrinterOnline(printerStatus);
            }
            return isPrinterOnline(printerStatus);
        }
        public string isPrinterOnline(string inkStatus)
        {
            Console.WriteLine($"Status of Printer in Library is {inkStatus}");
            return inkStatus;
        }

        public void getAllComputerStatus()
        {
            isComputerOnline(computerStatus);
        }
        public string isComputerOnline(string isComputerAlive)
        {
            Console.WriteLine($"Status of Computers in Library is {isComputerAlive}");
            return isComputerAlive;
        }

        public void getReturnedBooks(List<string> libReturnedBooks)
        {
            foreach (var item in libReturnedBooks)
            {
                returnedBooks.Add(item);
            }
            Console.WriteLine("These books are returned by customers");
            returnedBooks.ForEach(list => Console.WriteLine(list));
        }
    }
}
