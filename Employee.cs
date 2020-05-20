using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LibrarySystem
{
    class Employee:LibrarySystem
    { 
        public List<string> Librarians;
        public string materialCheckoutAssistant;
        public string libraryManager;
        public bool canIHelpStatus;
        public string employeeName;
        public string employeeId;
        public string employeeDepartment;
        public string employeeRole;
        public List<string> rolesInDepartment;


        public bool LibraryFrontDesk(bool canIHelp)
        {
            canIHelpStatus = canIHelp;
            return canIHelpStatus;

        }

        
 
    }
    public class Product
    {
        private Initialize oInit;

    }
}
