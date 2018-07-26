using System;

namespace exceptionpractice
{
    [Serializable]
    public class CustomException : Exception
    {
        public CustomException() :
            base("My custom exception...")
        {
        }

        public CustomException(String message) :
            base(message)
        {
        }
    }
}
