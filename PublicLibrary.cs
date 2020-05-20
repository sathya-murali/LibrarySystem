using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public class LibrarySystem
    {
        public List<string> computers = new List<string> { };
        public List<string> printers = new List<string> { };
        public List<string> cds = new List<string> { };
        public int totalNoOfBooksInSystem;
        public int totalNoofBooksByCategory;
        public int totalNoOfComputers;
        public int totalNoOfPrinters;
        public string libraryName;
        public string libraryAddress;
        public string libraryContantNumber;
        
        public void Peripherals(List<string> libComputers, List<string> libPrinters, List<string> libCds)
        {
            computers = libComputers;
            printers = libPrinters;
            cds = libCds;
            Console.WriteLine("List of Computers Name");
            computers.ForEach(equipment=>Console.WriteLine(equipment));
            Console.WriteLine("List of Printers Name");
            printers.ForEach(equipment2 => Console.WriteLine(equipment2));
            Console.WriteLine("List of CD's Available");
            cds.ForEach(equipment3 => Console.WriteLine(equipment3));  
        }        

    }
}
