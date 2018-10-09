namespace Library.Common.Exceptions
{
    using System;
    // must be from ApplicationException
    public class InvalidFieldException : Exception
    {
        public InvalidFieldException()
        {

        }

        public InvalidFieldException(string message)
        : base(message)
        {
        }

        public InvalidFieldException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
