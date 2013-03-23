using System;
using System.Collections.Generic;
using System.Linq;

class AudioDocument : MultimediaDocument
{
    public int SampleRateInHz { get; protected set; }

    public AudioDocument(string name) : base(name)
    {
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "samplerate")
        {
            this.SampleRateInHz = int.Parse(value.ToString());
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRateInHz));
        base.SaveAllProperties(output);
    }
}

