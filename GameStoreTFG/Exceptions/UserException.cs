using System;
using System.Runtime.Serialization;

namespace GameStoreTFG.Exceptions
{
    [Serializable]
    public class UserException : Exception
    {
        public UserException () : base() { }
        public UserException (string message) : base(message) { }
        public UserException (string message, Exception innerException) : base(message, innerException) { }
        public UserException (SerializationInfo info, StreamingContext context) : base (info, context) { }
    }
}
