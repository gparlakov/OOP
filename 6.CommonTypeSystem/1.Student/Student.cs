using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string  firstName,
                        middleName,
                        lastName,
                        SSN,
                        email,
                        address,
                        mobilePhone;
        private University university;
        private Speciality speciality;
        private Faculty faculty;

        public Student(string firstName,string lastName,string ssn)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.SSN = ssn;
        }

        public string E_Mail
        {
            get
            {
                return this.email;
            }
            set
            {               
                if (value.IndexOf('@') > 0 && value.IndexOf('.') > 0 && value.IndexOf('@') < value.IndexOf('.'))
                {
                    this.email = value;
                }
            }
        }

        
    }
}
