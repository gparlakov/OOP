using System;
using System.Collections.Generic;
using System.Linq;

abstract class OfficeDocument : EncryptableDocument
{
    public string Version { get; protected set; }

    protected OfficeDocument(string name)
        : base(name)
    {
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "version")
        {
            this.Version = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("version", this.Version));
        base.SaveAllProperties(output);
    }
}

