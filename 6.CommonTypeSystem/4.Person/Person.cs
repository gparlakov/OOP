using System;
using System.Linq;

namespace Person
{
    internal class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }

        public Person(string name, int age) : this(name)
        { 
            this.Age = age;
        }

        public string Name { get; set; }

        public int? Age { get; set; }

        public override string ToString()
        {
            string personString = this.Name;
            if (this.Age == null)
            {
                personString += " age is not specified";
            }
            else
            {
                personString += string.Format(" {0}", this.Age);
            }

            return personString;
        }
    }
}