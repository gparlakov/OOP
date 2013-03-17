using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class PersonTest
    {
        static void Main()
        {
            Person gosho = new Person("Gosho");
            Person pesho = new Person("Pesho", 5);

            Console.WriteLine(gosho);
            Console.WriteLine(pesho);
        }
    }
}
