namespace School
{
    internal class Human : BaseSchoolClass
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly int age;

        public Human(string name, string lastName, int age)
        {
            this.firstName = name;
            this.lastName = lastName;
            this.age = age;
        }

        public string Name
        {
            get
            {
                return this.firstName;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        //will not show the comment
        public override string ToString()
        {
            return string.Format("{0,10} {1,10}, Age:{2,3}, years", this.firstName, this.lastName, this.age);
        }
    }
}
