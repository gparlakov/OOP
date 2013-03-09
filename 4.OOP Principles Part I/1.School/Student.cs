namespace School
{
    internal class Student : Human
    {
        private string classNumber;        

        public Student(string name,string lastName, int age, string classNumber)
            : base(name,lastName, age)
        {           
            this.classNumber = classNumber;            
        }

        public string ClassNumber
        {
            get
            {
                return this.classNumber;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Class Number: " + this.classNumber;
        }
    }
}
