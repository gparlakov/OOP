
namespace Animals
{
    public abstract class Animal : ISound   
    {
        protected int age;
        protected string name;
        protected SexOfAnimal sex;

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public SexOfAnimal Sex
        {
            get
            {
                return this.sex;
            }
        }

        public abstract string MakeSound();
        
    }
}
