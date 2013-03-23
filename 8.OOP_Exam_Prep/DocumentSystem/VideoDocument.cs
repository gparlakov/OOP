using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VideoDocument : MultimediaDocument
{
    public int FrameRate { get; protected set; }

    public VideoDocument(string name)
        : base(name)
    {
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "framerate")
        {
            this.FrameRate = int.Parse(value.ToString());
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
        base.SaveAllProperties(output);
    }
}
