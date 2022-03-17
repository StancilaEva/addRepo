using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment
{
    internal class StringIsNullException : Exception
    {
        public StringIsNullException(string? message) : base(message)
        {
        }
    }
}
