using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
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
