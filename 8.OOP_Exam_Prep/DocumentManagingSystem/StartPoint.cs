using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagingSystem
{
    class StartPoint
    {
        static void Main()
        {
            //Document text1 = new TextDocument("text1.txt");            
            //text1.LoadProperty("charset", "windows");
            ////text1.ChangeContent("old content");
            //Console.WriteLine(text1);
            //text1.ChangeContent("new Content");
            //Console.WriteLine(text1);
            //if (text1 is EncryptableDocument)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}


            IList<string> allCommands = DocumentSystem.ReadAllCommands();
            DocumentSystem.ExecuteCommands(allCommands);
        
        }
    }
}
