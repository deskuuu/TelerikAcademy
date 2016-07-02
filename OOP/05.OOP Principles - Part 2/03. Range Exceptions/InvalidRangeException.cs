namespace _03.Range_Exceptions
{
    using System;

    class InvalidRangeException<T> : Exception
    {
        public T Start;
        public T End;

        public InvalidRangeException(string msg, T start, T end)
            : base(msg)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
