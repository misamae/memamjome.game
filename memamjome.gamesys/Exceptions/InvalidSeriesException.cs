using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memamjome.gamesys.Exceptions
{
    [Serializable]
    public class InvalidSeriesException : Exception
    {
        public InvalidSeriesException() { }
        public InvalidSeriesException(string message) : base(message) { }
        public InvalidSeriesException(string message, Exception inner) : base(message, inner) { }
        protected InvalidSeriesException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
