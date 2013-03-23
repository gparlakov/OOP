using System;
using System.Collections.Generic;
using System.Linq;


abstract class MultimediaDocument : BinaryDocument
{
    public int LenghtInSeconds { get; protected set; }

    public MultimediaDocument(string name)
        : base(name)
    {
    }
    public override void LoadProperty(string key, string value)
    {
        if (key == "length")
        {
            this.LenghtInSeconds = int.Parse(value.ToString());
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("length", this.LenghtInSeconds));
        base.SaveAllProperties(output);
    }
}

