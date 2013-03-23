using System;
using System.Collections.Generic;
using System.Linq;

public abstract class BinaryDocument : Document
{
    public int SizeBytes { get; protected set; }
    protected BinaryDocument(string name)
        : base(name)
    {
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "size")
        {
            this.SizeBytes = int.Parse(value.ToString());
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("size", this.SizeBytes));
        base.SaveAllProperties(output);
    }

}
