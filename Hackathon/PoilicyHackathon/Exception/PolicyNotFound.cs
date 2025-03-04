using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoilicyHackathon.Exception
{
    internal class PolicyNotFound : ApplicationException
    {
        public PolicyNotFound(string msg) : base(msg)
        {

        }

    }
}
