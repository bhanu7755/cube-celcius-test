using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureConversion.API.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException()
        {
        }

        public InvalidInputException(string message)
            : base(message)
        {
        }

        public InvalidInputException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
