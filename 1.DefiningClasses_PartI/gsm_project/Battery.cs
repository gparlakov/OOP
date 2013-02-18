using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsm_project
{
    public class Battery
    {
        private string model;
        private float hoursIdle, hoursTalk;


        public Battery()
            : this("unknown model", 0, 0)
        {
        }

        public Battery(string model, float hoursIdle, float hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public float HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public float HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}, Hours Standby {1}, Talk Time {2}",model,HoursIdle,HoursTalk);
        }
    }
}
