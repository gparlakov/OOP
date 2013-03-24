using System;
using System.Linq;


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
