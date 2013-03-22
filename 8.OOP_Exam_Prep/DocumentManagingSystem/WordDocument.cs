using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentManagingSystem
{
    public class WordDocument : EncryptableDocument, IEditable
    {
        public WordDocument(string name)
            :base(name)
        {            
        }

        public void ChangeContent(string newContent)
        {
            var oldContent = this.Properties.Find(x=>x.Key == "content)");
            if (oldContent.Key != null)
            {
                oldContent = new KeyValuePair<string,object>("content",newContent);
            }
            else
            {
                this.properties.Add(new KeyValuePair<string, object>("content", newContent));
            }
        }
        
    }
}
