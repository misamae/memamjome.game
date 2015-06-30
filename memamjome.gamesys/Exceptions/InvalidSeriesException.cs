using System;

namespace memamjome.gamesys.Exceptions
{
    [Serializable]
    public class InvalidSeriesException : Exception
    {
        public InvalidSeriesException() { }

        public InvalidSeriesException(string message) : base(message) { }

        public InvalidSeriesException(string message, Exception inner) : base(message, inner) { }

        protected InvalidSeriesException(System.Runtime.Serialization.SerializationInfo info
            , System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
