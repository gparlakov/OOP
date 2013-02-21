//Define a class that holds information about a mobile phone device: model, manufacturer, 
//price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). 
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
//Define several constructors for the defined classes that take different sets of arguments (the full information for 
//the class or part of it). Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.

using System;

namespace gsm_project
{
    public class GSM
    {
        private Battery BatteryType;
        private Display displayType;
        private string model,
                       manufacturer,
                       owner;
        private decimal price;

        public GSM()            
        {
        }

        public GSM(string manufacturer, string model,
            string owner = null, decimal price = 0)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.owner = owner;
            this.price = price;
            this.displayType = new Display();
            this.BatteryType = new Battery();
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
           string owner = "[unknown owner]", decimal price = 0)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.owner = owner;
            this.price = price;
            this.displayType = display;
            this.BatteryType = battery;
        }

        public string Manufacturer 
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value.Length > 2)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Manufacturer's name should be more than 2 symbols");
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
            return string.Format("{6}GSM is {0} {1}.\nDisplay {2}\nBattery {3}\nOwner: {4} Price: {5} lv",
                this.Manufacturer, this.Model, this.displayType, this.BatteryType, this.Owner, this.Price,new String);
        }
    }
}
