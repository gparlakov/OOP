namespace Animals
{
    public class TomCat : Cat
    {
        public TomCat(string name, int years) 
            : base(name, SexOfAnimal.Male, years)
        {
        }

        public override string MakeSound()
        {
            return "TomCat sais mrrrrr";
        }
    }
}
