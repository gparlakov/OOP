using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsm_project
{
    public class Display
    {
        private int colors;
        private float size;

        
        public float Size { get; set; }
        public int Colors     
        {
            get
            {
                return this.colors;
            }

            set
            {
                if (value > 0)
                {
                    this.colors = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Value of colors should be more than 0");
                }
            }
            
        }

        public Display()
            : this (0,0)
        {
        }

        //constructor with mandatory size(in inches) and rest can be blank 
        public Display(float size, int colors = 0)
        {
            this.size = size;
            this.colors = colors;
        }

        /// <summary>
        ///     Returns the display's charachteristics in a string
        /// </summary>
        /// <returns>Always - The display's size - and if available number of colors</returns>
        public override string ToString()
        {
            string displayString=null;
            if (this.Colors == 0)
            {
                displayString = String.Format("Size : {0}in",this.Size);
            }
            else
            {
                displayString = string.Format("Size : {0}in colors: {1}",this.Size,this.Colors);
            }
            return displayString;            
        }


    }
}
