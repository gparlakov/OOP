using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WordDocument : OfficeDocument, IEditable
{
    public int Chars { get; protected set; }

    public WordDocument(string name)
        : base(name)
    {
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "chars")
        {
            this.Chars = int.Parse(value.ToString());
        }
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("chars", this.Chars));
        base.SaveAllProperties(output);
    }

    public void ChangeContent(string newContent)
    {
        this.LoadProperty("content", newContent);
    }
}

