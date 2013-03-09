/*Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful  * constructors and methods. Dogs, frogs and cats are Animals. All animals * can produce sound (specified by the ISound interface). Kittens and tomcats * are cats. All animals are described by age, name and sex. Kittens can be only  * female and tomcats can be only male. Each animal produces a specific sound. Create * arrays of different kinds of animals and calculate the average age of each kind of * animal using a static method (you may use LINQ).*/

using System;
using System.Collections.Generic;
using System.Linq;


namespace Animals
{
    class AnimalsTest
    {
        static void Main()
        {
            Cat[] cats = new Cat[5]{
                new Cat("visi",SexOfAnimal.Female,15),
                new Kitten("misi",3),
                new TomCat("aro",17),
                new Kitten("myri",4),
                new Cat("pisi",SexOfAnimal.Male,9)
            };

            Dog[] dogs = new Dog[3]{
                new Dog("Sharo",SexOfAnimal.Male,6),
                new Dog("Djaro",SexOfAnimal.Male,35),
                new Dog("Bara",SexOfAnimal.Female,5)
            };

            Frog[] frogs = new Frog[10]{
                new Frog("Kermit's Cousin 1",SexOfAnimal.Male, 5),
                new Frog("Kermit's Cousin 21",SexOfAnimal.Male, 53),
                new Frog("Kermit's Cousin 14",SexOfAnimal.Male, 52),
                new Frog("Kermit's Cousin 3",SexOfAnimal.Male, 15),
                new Frog("Kermit's Cousin 31",SexOfAnimal.Male, 15),
                new Frog("Kermit's Cousin 115",SexOfAnimal.Male, 15),
                new Frog("Kermit's Cousin 1223",SexOfAnimal.Male, 42),
                new Frog("Kermit's Cousin 145",SexOfAnimal.Male, 5),
                new Frog("Kermit's Cousin 16",SexOfAnimal.Male, 5),
                new Frog("Kermit's Cousin 17",SexOfAnimal.Male, 3)

            };

            Console.WriteLine("Average agea of Cats: {0}",AverageAge(cats));
            Console.WriteLine("Average agea of Dogs: {0}", AverageAge(dogs));
            Console.WriteLine("Average agea of Frogs: {0}", AverageAge(frogs));

            List<Animal> allAnimals = new List<Animal>();
            allAnimals.AddRange(cats);
            allAnimals.AddRange(dogs);
            allAnimals.AddRange(frogs);

            Console.WriteLine("\nAnimals ordered by Age:");
            foreach (var animal in allAnimals.OrderBy(x=>x.Age))
            {
                Console.WriteLine("--{0}--",animal.MakeSound());
            }
        }

        static float AverageAge(ICollection<Animal> animals)
        {            
            return (float)animals.Average(x => x.Age);
        }
    }
}
