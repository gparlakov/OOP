using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionForStringBuilder
{
    public static class SubstringExtensionForStringBuilder
    {
        public static string SubString(this StringBuilder ste,int index)
        {
            string toString = ste.ToString();
            return toString.Substring(index);
        }

        public static string SubString(this StringBuilder ste, int index,int lenght)
        {
            string toString = ste.ToString();
            return toString.Substring(index,lenght);
        }
    }
}
