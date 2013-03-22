using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagingSystem
{
    public abstract class Document : IDocument
    {
        public string Name { get; protected set; }
        public string Content { get; protected set; }

        protected List<KeyValuePair<string,object>> properties;

        public List<KeyValuePair<string,object>> Properties
        {
            get 
            {
                return properties; 
            }

            protected set 
            {
                foreach (var item in value)
                {
                    this.properties.Add(new KeyValuePair<string,object>(item.Key, item.Value));
                }
            }
        }

        protected Document(string name)
        {
            this.Name = name;
            this.properties = new List<KeyValuePair<string, object>>();
            this.properties.Add(new KeyValuePair<string,object>("name",name));
        }

        public void LoadProperty(string key, string value)
        {
            this.properties.Add(new KeyValuePair<string, object>(key, value));
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            foreach (var property in this.Properties)
            {
                output.Add(new KeyValuePair<string, object>(property.Key, property.Value));
            }
        }

        private List<KeyValuePair<string, object>> OrderProperties()
        {           
            this.Properties.RemoveAll(x => string.IsNullOrWhiteSpace(x.Value.ToString()));
            return this.Properties.OrderBy(x => x.Key).ToList();
        }


        public override string ToString()
        {            
            StringBuilder toStringBuilder = new StringBuilder();
            var orederedProperties = OrderProperties();

            toStringBuilder.Append(this.GetType().Name + "[");

            foreach (var prop in orederedProperties)
            {
                toStringBuilder.Append(prop.Key + "=" + prop.Value + ";");
            }
            toStringBuilder.Remove(toStringBuilder.Length - 1, 1);
            toStringBuilder.Append("]");

            return toStringBuilder.ToString();
        }

        

        
    }
}
