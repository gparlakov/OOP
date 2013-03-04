using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankTest
    {
        static void Main()
        {
            Customer person = new Customer("Pesho", CustomerType.Individual);
            Console.WriteLine(person.CustomerType + "\nName: " + person.Name);
            
           
        }
    }
}
