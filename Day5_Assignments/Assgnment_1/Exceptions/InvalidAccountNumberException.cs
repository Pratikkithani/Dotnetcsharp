using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgnment_1.Exceptions
{
    class InvalidAccountNumberException : ApplicationException
    {
        public InvalidAccountNumberException(string msg) : base(msg)
        {

        }
    }
}
