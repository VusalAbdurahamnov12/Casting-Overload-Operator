using System;
using System.Collections.Generic;
using System.Text;

namespace Casting_operator_overload.Exceptions
{
    internal class NotAvailableException:Exception
    {
        public class NotAvailableExceptions : Exception
        {
            public NotAvailableExceptions(string message) : base(message) { }
        }
    }
}
