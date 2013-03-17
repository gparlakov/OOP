using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }       

        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }

        public Person(string name,int age)
            :this(name)
        {            
            this.Age = age;
        }

        public override string ToString()
        {
            string personString = this.Name;
            if (this.Age == null)
            {
                personString += " age is not specified";
            }
            else
            {
                personString += " " + age;
            }

            return personString;
        }


    }
}
