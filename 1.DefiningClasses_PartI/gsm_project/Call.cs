using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmProject
{
    public class Call
    {
        private DateTime dateTimeOfCall;
        private string phoneNumber;
        private int duration; //in seconds

        //Date time will be set to "now" on initializing a new 
        //call so I only need the get to be public        
        public DateTime DateTimeOfCall 
        {
            get
            {
                return this.dateTimeOfCall;
            }
            private set
            {
                this.dateTimeOfCall = value;
            }
        }

        /// <summary>
        ///     Should be longer than 2 and shorter then 25 symbols and only digits
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                bool isCorrectPhoneNumber = true;

                //check if the number is longer than 2 and shorter then 25 symbols 
                // and if it's comprised only of digits 
                if (value.Length < 25 && value.Length >= 3)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!char.IsDigit(value[i]))
                        {
                            isCorrectPhoneNumber = false;
                            break;
                        }
                    }
                }
                else
                {
                    isCorrectPhoneNumber = false;
                }

                if (isCorrectPhoneNumber)
                {
                    this.phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("Number should be between 3 and 25 symbols and should consisit only of digits!");
                }
            }
        }

        //Duration will be set on initialization of
        //a new call so I only need get-er to be public
        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }

        
        /// <summary>
        ///     Initializes a new Call instance with DateTimeOfCall - set to now
        ///     Needs number longer than 2 and shorter then 25 symbols and only digits
        ///     and duration - in seconds
        /// </summary>
        /// <param name="number"></param>
        /// <param name="duration"></param>
        public Call(string number,int duration )
        {
            this.DateTimeOfCall = DateTime.Now;
            this.PhoneNumber = number;
            this.Duration = duration;
        }

        public override string ToString()
        {
            return string.Format("On date[{0:dd,MM,yy}] time[{0:HH:MM:ss}] A call was made to {1}; Duration {2} min, {3} sec",DateTimeOfCall,PhoneNumber,duration/60,duration%60);
        }

    }
}
