using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Animal
    {
        public Frog(string name,SexOfAnimal sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        public override string MakeSound()
        {
            return "Frog says: Good Evening Gentelmen I am a cousin of Kermit";
        }
    }
}
