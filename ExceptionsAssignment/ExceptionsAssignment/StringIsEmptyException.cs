using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment
{
    internal class StringIsEmptyException : Exception
    {
        public StringIsEmptyException()
        {
        }

        public StringIsEmptyException(string? message) : base(message)
        {
        }
    }
}
