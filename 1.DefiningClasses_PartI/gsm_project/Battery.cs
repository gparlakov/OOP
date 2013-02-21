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
        private BatteryType batteryType;
        public Battery()
            //: this("[unknown owner]", 0, 0, 0)
        {
        }
        
    
        //constructor with mandatory model and rest can be left blank
        public Battery(string model, float hoursIdle=0, float hoursTalk=0,BatteryType batteryType = 0)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }
        
        public string Model
        {
            get { return model; }
            set { this.model = value; }
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

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
        
        /// <summary>
        ///     Override - gives the battey's properties
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}: {3} Standby {1} h, Talk Time {2} h", this.Model, this.HoursIdle, this.HoursTalk,this.BatteryType);
        }

        /// <summary>
        ///     Define operator '>' - compare the talk time of the batteries and ignore the idle hours
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>True if first has more TALK hours than second </returns>
        public static bool operator > (Battery first, Battery second)
        {
            bool firstIsBigger = true;
            if (first.HoursTalk<second.hoursTalk)
            {
                firstIsBigger = false;
            }
            return firstIsBigger;	
        }

        /// <summary>
        ///     Define operator < - compare the talk time of the batteries and ignore the idle hours
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns> True if first has more TALK hours than second </returns>
        public static bool operator <(Battery first, Battery second)
        {
            bool firstIsBigger = true;
            if (first.HoursTalk > second.hoursTalk)
            {
                firstIsBigger = false;
            }
            return firstIsBigger;
        }

        //public bool operator == (Battery first, Battery second)
        //{
        //    bool firstIsBigger = true;
        //    if (first.HoursTalk == second.hoursTalk)
        //    {
        //        firstIsBigger = false;
        //    }
        //    return firstIsBigger;
        //}

    }
}
