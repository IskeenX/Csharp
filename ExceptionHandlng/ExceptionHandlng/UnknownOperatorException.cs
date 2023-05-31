 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlng
{
    internal class UnknownOperatorException : Exception
    {
        public DateTime TimeStamp { get; set; }
    }
}