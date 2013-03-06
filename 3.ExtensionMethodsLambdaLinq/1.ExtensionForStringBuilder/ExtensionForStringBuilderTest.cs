using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionForStringBuilder
{
    class ExtensionForStringBuilderTest
    {
        static void Main()
        {
            try
            {
                StringBuilder builder = new StringBuilder();

                builder.Append("TestTestTest");
                builder.Append("MestMostMastMist");
                Console.WriteLine(builder.SubString(14));
                Console.WriteLine(builder.SubString(14, 6));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
