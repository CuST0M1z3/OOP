using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ExceptionTask
{
    public class InvalidRangeException<T> : Exception
    {
        private T rangeStart;
        private T rangeEnd;

        public T RangeStart { get; set; }
        public T RangeEnd { get; set; }

        public InvalidRangeException(string message, T rangeStart, T rangeEnd)
            : base(message)
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

    }
}
