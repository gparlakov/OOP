using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PDFDocument : EncryptableDocument
{
    public int Pages { get; protected set; }

    public PDFDocument(string name)
        : base(name)
    {
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "pages")
        {
            this.Pages = int.Parse(value.ToString());
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("pages", this.Pages));
        base.SaveAllProperties(output);
    }
}

