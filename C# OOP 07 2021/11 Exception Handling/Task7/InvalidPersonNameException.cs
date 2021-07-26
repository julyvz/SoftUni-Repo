using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    class InvalidPersonNameException : Exception
    {
        public InvalidPersonNameException(string message)
            : base(message)
        {

        }
    }
}
