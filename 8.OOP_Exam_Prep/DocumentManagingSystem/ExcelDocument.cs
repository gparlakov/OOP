using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentManagingSystem
{
    public class ExcelDocument : EncryptableDocument
    {
        public ExcelDocument(string name)
            :base(name)
        {            
        }
    }
}
