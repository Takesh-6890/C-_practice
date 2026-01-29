using System;
using System.Runtime.Serialization;

namespace User_regestration_ExceptionHandlig
{
    [Serializable]
    public class AgeNotValidException : Exception
    {
        public AgeNotValidException() { }
        public AgeNotValidException(string message) : base(message) { }
        public AgeNotValidException(string message, Exception inner) : base(message, inner) { }
        protected AgeNotValidException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
