using System;
using System.Runtime.Serialization;

namespace Builder
{
    [Serializable]
    internal class HamburgerNotReadyException : Exception
    {
        public HamburgerNotReadyException()
        {
        }

        public HamburgerNotReadyException(string message) : base(message)
        {
        }

        public HamburgerNotReadyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HamburgerNotReadyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}