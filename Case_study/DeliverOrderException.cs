using System.Runtime.Serialization;

namespace Case_study
{
    [Serializable]
    internal class DeliverOrderException : Exception
    {
        private object value;

        public DeliverOrderException()
        {
        }

        public DeliverOrderException(object value)
        {
            this.value = value;
        }

        public DeliverOrderException(string? message) : base(message)
        {
        }

        public DeliverOrderException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeliverOrderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}