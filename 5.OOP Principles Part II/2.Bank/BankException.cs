using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class BankException : Exception
    {
        public BankException()
            : base()
        {
        }

        public BankException(string message)
            : base(message)
        {
        }
    }
}
