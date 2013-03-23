using System;
using System.Linq;
using System.Collections.Generic;


    public class TextDocument : Document, IEditable
    {
        public string Charset { get; protected set; }

        public TextDocument(string name)
            :base(name)
        {            
        }
    
        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "charset")
            {
                this.Charset = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("charset", this.Charset));
            base.SaveAllProperties(output);
        }
    
}
