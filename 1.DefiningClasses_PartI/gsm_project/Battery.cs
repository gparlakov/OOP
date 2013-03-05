using System;
using System.Linq;

namespace GsmProject
{
    public class Battery
    {
        private string model;
        private float? hoursIdle, hoursTalk;
        private BatteryType batteryType;       
        
    
        //constructor with mandatory model and rest can be left blank
        public Battery(string model, BatteryType batteryType, float? hoursIdle, float? hoursTalk) //= BatteryType.LiIon
        {
            this.Model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public Battery(string model, BatteryType batteryType) //= BatteryType.LiIon
            :this(model,batteryType,null,null)
        {            
        }

        ///Three arguments constructor that assumes hours equals hours talk and idle
        public Battery(string model, BatteryType batteryType, float? hours) 
            :this(model, batteryType, hours, hours)
        {            
        }

        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }

        public float? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value >= 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Hours idle can't be negative or 0");
                }
            }
        }

        public float? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value >= 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Hours tal'k cant be negative or 0");
                }
            }
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
