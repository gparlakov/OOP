using System;
using System.Linq;

namespace Bank
{
    class BankTest
    {
        static void Main()
        {
            try
            {
                Customer person = new Customer("Pesho", CustomerType.Individual);
                Console.WriteLine(person.CustomerType + "\nName: " + person.Name);
            }
            catch (BankException ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
