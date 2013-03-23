using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExcelDocument : OfficeDocument
{
    public int Rows { get; protected set; }
    public int Cols { get; protected set; }

    public ExcelDocument(string name)
        : base(name)
    {
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "rows")
        {
            this.Rows = int.Parse(value.ToString());
        }
        else if (key == "cols")
        {
            this.Cols = int.Parse(value.ToString());
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("rows", this.Rows));
        output.Add(new KeyValuePair<string, object>("cols", this.Cols));
        base.SaveAllProperties(output);
    }

}
