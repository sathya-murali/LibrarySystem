using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    class MobileLibrary:LibrarySystem
    {
        private string minibookcategory;
        public string MiniBookCategory;
        public List<string> printers;
        public List<string> computers;
        public string bookAuthor;


        public void mobilelib()
        {
            //MobileLibrary mobLib = new MobileLibrary();
            bookAuthor = "agasta";
            MiniBookCategory = "short thriller";
            printers.Add("MiniLibPrinter1");
            printers.Add("MiniLibPrinter2");
            computers.Add("computer1");
            computers.Add("computer2");
        }
        
        
        
    }
}
