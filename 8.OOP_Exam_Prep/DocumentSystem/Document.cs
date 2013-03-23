using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public abstract class Document : IDocument
    {
        public string Name { get; protected set; }
        public string Content { get; protected set; }
        
        protected Document(string name)
        {
            this.Name = name;
        }
               
        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            else if (key == "content")
            {
                this.Content = value;
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string,object>("name",this.Name));
            output.Add(new KeyValuePair<string,object>("content",this.Content));            
        }

        public override string ToString()
        {                               
            StringBuilder toStringBuilder = new StringBuilder();
            List<KeyValuePair<string,object>> orederedProperties = new List<KeyValuePair<string,object>>();

            SaveAllProperties(orederedProperties);
            orederedProperties.Sort((prop,prop2) => prop.Key.CompareTo(prop2.Key));

            toStringBuilder.Append(this.GetType().Name + "[");

            foreach (var prop in orederedProperties)
            {
                if (prop.Value != null && prop.Value.ToString() != "0")
                {
                    toStringBuilder.Append(prop.Key + "=" + prop.Value + ";");
                }                
            }
            toStringBuilder.Remove(toStringBuilder.Length - 1, 1);
            toStringBuilder.Append("]");

            return toStringBuilder.ToString();        
        } 
}
