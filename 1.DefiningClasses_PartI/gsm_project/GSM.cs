//Define a class that holds information about a mobile phone device: model, manufacturer, 
//price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). 
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
//Define several constructors for the defined classes that take different sets of arguments (the full information for 
//the class or part of it). Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.

using System;

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
        private static string iPhone4S;

        public GSM()            
        {
        }

        public GSM(string manufacturer, string model
            )
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = "[unknown owner]";
            //this.price = price;
            this.displayType = new Display();
            this.BatteryInfo = new Battery();
        }

        /// <summary>
        ///     Construct an instance of GSM Class with given parameters. Manufacturer and Model are mandatory
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <param name="model"></param>
        /// <param name="display"></param>
        /// <param name="battery"></param>
        /// <param name="owner"></param>
        /// <param name="price"></param>
        public GSM(string manufacturer, string model,Display display,Battery battery,
           decimal price, string owner = "[unknown owner]")
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = owner;
            this.Price = price;
            this.displayType = display;
            this.BatteryInfo = battery;
        }

        public string Manufacturer 
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value.Length > 1)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Manufacturer's name should be 2 symbols ot more");
                }
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
                if (this.model=="iPhone4S")
                {
                    iPhone4S = "true";
                }
            }
        }

        public static GSM IPhone4S
        {            
            get
            {                
                return new GSM("Apple", "iPhone4S",new Display(4.5f,65535),new Battery("AppleBat4S",BatteryType.NiMH,211,12),1499);                
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
        /// Override ToString()
        /// </summary>
        /// <returns>GSM's Characteristics</returns>
        public override string ToString()
        {
            string result = string.Format("{6}\nGSM is {0} {1}.\nDisplay {2}\nBattery {3}\nOwner: {4}, Price: {5} lv",
                this.Manufacturer, this.Model, this.displayType, this.BatteryInfo, this.Owner, this.Price,new String('-',25));
            //if (IPhone4S!="This is not iPhone4S")
            //{
            //    result += IPhone4S;
            //}

            return result;
        }
    }
}
