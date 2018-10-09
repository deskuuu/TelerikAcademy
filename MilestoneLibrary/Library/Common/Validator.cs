namespace Library.Common
{
    using Library.Common.Exceptions;

    public static class Validator
    {
        public static string ValidateData(string data, int minLength, string message)
        {
            if (string.IsNullOrEmpty(data) || data.Length < minLength)
            {
                throw new InvalidFieldException(message);
            }
            else
            {
                return data;
            }
        }
    }
}