using System;
using System.Linq;

namespace Human
{
    public class Student : Human
    {
        private float grade;

        public Student(string fName, string lName, float grade)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.grade = grade;
        }               

        public float Grade
        {
            get
            {
                return this.grade;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} grade: {1:f2}",base.ToString(), this.grade);
        }

    }
}
