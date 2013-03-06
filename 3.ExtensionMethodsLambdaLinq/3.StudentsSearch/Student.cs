namespace StudentsSearch
{
    public struct Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string fName, string lName, int age)
            : this()
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format("Student: {0} {1} {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
