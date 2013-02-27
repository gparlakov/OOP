//Define a class that holds information about a mobile phone device: model, manufacturer, 
//price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). 
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
//Define several constructors for the defined classes that take different sets of arguments (the full information for 
//the class or part of it). Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.

using System;
using System.Collections.Generic;

namespace GsmProject
{
    /// <summary>
    ///     GSM Class
    ///     Exceptions - ArgumentOutOfRange for zero or negative price, display size 
    /// </summary>
    /// 
    //TODO: Property for setting Battery and Display after initialization
    public class GSM
    {
        private Battery BatteryInfo;
        private Display displayType;
        private string model,
                       manufacturer,
                       owner;
        private decimal price;        
        private List<Call> callHistory;
        private int callsCounter=0;

        /// <summary>
        /// Blank constructor
        /// </summary>
        public GSM()
            : this(null, null)
        {
        }

        /// <summary>
        /// The least possible constructor with Manufacturer and Model mandatory
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <param name="model"></param>
        public GSM(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = "[unknown owner]";
            //this.price = price;
            this.displayType = new Display();
            this.BatteryInfo = new Battery();
            this.callHistory = new List<Call>();            
        }

        /// <summary>
        ///     Construct an instance of GSM Class with given parameters. Manufacturer and Model are mandatory
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <param name="model"></param>
        /// <param name="display">Object of class Display</param>
        /// <param name="battery">Object of class Battery</param>
        /// <param name="owner">String</param>
        /// <param name="price"></param>
        public GSM(string manufacturer, string model, Display display, Battery battery,
           decimal price, string owner = "[unknown owner]")
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = owner;
            this.Price = price;
            this.displayType = display;
            this.BatteryInfo = battery;
            this.callHistory = new List<Call>();            
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        /// <summary>
        /// Holds a GSM instance information about iPhone
        /// </summary>
        public static GSM IPhone4S
        {
            get
            {
                return new GSM("Apple", "iPhone4S", new Display(4.5f, 65535), new Battery("AppleBat4S", BatteryType.NiMH, 211, 12), 1499);
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Price should be more than 0 ");
                }
            }
        }

        /// <summary>
        /// Adds a call to the CallHistory
        /// </summary>
        public Call AddCallToHistory
        {
            set
            {
                this.callHistory.Add(value);                
            }
        }

        
        
        /// <summary>
        /// Prints last calls from history
        /// </summary>
        /// <param name="numberCalls">How many calls to print </param>        
        public void CallHistoryPrint(int numberCalls = 10)
        {
            Console.WriteLine("{1} Printing last {0} calls: {1}",numberCalls,new string('-',15));
            for (int i = this.callHistory.Count-1,counter=0; i >= 0 && counter < numberCalls; i--,counter++)
            {
                Console.WriteLine("{0} : {1}",i+1,this.callHistory[i]);
            }
        }

        /// <summary>
        ///     Removes a call by its index
        /// </summary>
        /// <param name="index">As indexed in CallHistoryPrint - meaning the first ever call was number 1  </param>
        public void RemoveCall(int index)
        {
            this.callHistory.RemoveAt(index - 1);
        }

        /// <summary>
        /// Clears tha call history
        /// </summary>
        public void ClearCallHistory()
        {
            this.callHistory.Clear();            
        }

        /// <summary>
        /// Calculates the total cost of calls 
        /// </summary>
        /// <param name="pricePerMinute">Price per minute</param>
        /// <returns></returns>
        public float CallsPrice(float pricePerMinute)
        {
            float time = 0;
            foreach (var item in this.callHistory)
            {
                time += item.Duration;
            }
            return (time * pricePerMinute) / 60;
        }

        /// <summary>
        /// Override ToString()
        /// </summary>
        /// <returns>GSM's Characteristics</returns>
        public override string ToString()
        {
            string result = string.Format("{6}\nGSM is {0} {1}.\nDisplay {2}\nBattery {3}\nOwner: {4}, Price: {5} lv",
                this.Manufacturer, this.Model, this.displayType, this.BatteryInfo, this.Owner, this.Price, new String('-', 25));
            //if (IPhone4S!="This is not iPhone4S")
            //{
            //    result += IPhone4S;
            //}

            return result;
        }


        //TODO : CallHistory in a file
    }
}
