using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionsForIEnumerable
{
    public class ExtensionException : Exception
    {
        public ExtensionException()
            :base()
        {

        }
        public ExtensionException(string message)
            : base(message)
        {

        }

    }
}
