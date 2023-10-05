using System.Runtime.Serialization;

namespace Contacts.Core.Exceptions
{
    public class InvalidNameException : Exception, ISerializable
    {
        public InvalidNameException(string message) : base(message)
        {
        }

        public InvalidNameException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
