using System;
using System.Linq;

namespace InvalidRangeExceptionGeneric
{
    public class InvalidRangeException<T> : SystemException
        where T : IComparable
    {
        public string Message { get; set; }

        public InvalidRangeException()
            :base()
        {
        }
        
        public InvalidRangeException(T rangeStart,T rangeEnd)
            :this()
        {
            this.Message = string.Format("Argument should be between {0} and {1}", rangeStart, rangeEnd);
        }
    }
}
