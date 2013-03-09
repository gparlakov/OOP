namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int years)
            : base(name, SexOfAnimal.Female, years)
        {
        }

        public override string MakeSound()
        {
            return "Kitten says mia miayauuyyyuuuu";
        }
    }
}
