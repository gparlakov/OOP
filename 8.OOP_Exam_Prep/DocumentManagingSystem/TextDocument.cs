using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentManagingSystem
{
    public class TextDocument : Document, IEditable
    {
        public TextDocument(string name)
            :base(name)
        {            
        }

        public void ChangeContent(string newContent)
        {
           
            if (this.Properties.Find(x => x.Key == "content").Key != null)
            {
                this.Properties.RemoveAll(x => x.Key == "content");
            }            
            this.properties.Add(new KeyValuePair<string, object>("content", newContent));
            
        }
    }
}
