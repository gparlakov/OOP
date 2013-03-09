namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, SexOfAnimal sex, int years)
        {
            this.age = years;
            this.name = name;
            this.sex = sex;
        }               

        public override string MakeSound()
        {
            return "Cat says Miauu";
        }
    }
}
