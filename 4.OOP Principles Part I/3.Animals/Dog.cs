namespace Animals
{
    public class Dog:Animal
    {
        public Dog(string name, SexOfAnimal sex, int years)
        {
            this.name = name;
            this.sex = sex;
            this.age = years;
        }
        
        public override string MakeSound()
        {
            return "Dog Barks: BRRRRARRARAAR";
        }
    }
}
