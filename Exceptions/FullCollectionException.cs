using System.Runtime.Serialization;

namespace ExtensionMethodsPart01.Exceptions
{
    public class FullCollectionException : Exception, ISerializable
    {
        public new const string Message = "This collection has reached the full capacity";

        public FullCollectionException() : base(Message) { }

        public FullCollectionException(string message) : base(message ?? Message) { }

        public FullCollectionException(string message, Exception innerException) : base(message ?? Message, innerException) { }
    }
}