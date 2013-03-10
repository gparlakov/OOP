using System;
using System.Linq;

namespace Bank
{
    /// <summary>
    /// Creates an instance of the Customer class with name and type.
    /// Name and CustomerType can be set on creation and after that are read-only properties 
    /// </summary>
    public class Customer
    {
        private string name;
        private CustomerType customerType;

        public Customer(string name, CustomerType type)
        {
            this.name = name;
            this.customerType = type;
        }
        
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public CustomerType CustomerType
        {
            get
            {
                return this.customerType;
            }
        }
    }
}
