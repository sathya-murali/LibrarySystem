using System;
using System.Runtime.Serialization;


namespace LibrarySystem
{
    [Serializable]
    public class ServiceUnavailableException : Exception
    {
        private static readonly string RESOURCE_UNAVAILABLE = "Librarian Unavailable";
        public ServiceUnavailableException(string RESOURCE_UNAVAILABLE) : base(RESOURCE_UNAVAILABLE) { }
    }

    [Serializable]
    public class InvalidIdException : Exception
    {
        private static readonly string INVALID_BOOKID = "Book Id provided is not Valid";

        public InvalidIdException(string INVALID_BOOKID) : base(INVALID_BOOKID) { }
    }

    [Serializable]

    public class InvalidBookReference : Exception
    {
        private static readonly string INVALID_BOOKREF = "Please check the name";

        public InvalidBookReference(string INVALID_BOOKREF) : base(INVALID_BOOKREF) { }
    }
    
}
