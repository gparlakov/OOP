using System;
using System.Linq;


namespace Human
{
    public abstract class Human
    {
        protected string firstName,
                        lastName;
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        virtual override public string ToString()
        {
            return String.Format("{0,10}, {1,15}" ,this.FirstName,this.LastName);
        }
    }
}
