using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student : ICloneable, IComparable<Student>
    {
        private string firstName,
                        middleName,
                        lastName,
                        SSN,
                        email,
                        address,
                        mobilePhone;
        
        public Student(string firstName, string lastName, string ssn)
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

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                this.mobilePhone = value;
            }
        }

        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Speciality Speciality { get; set; }
        
        public override bool Equals(object student)
        {
            bool result = false;
            if (student is Student)
            {
                Student checkStudent = (Student)student;
                if (this.firstName == checkStudent.firstName && this.lastName == checkStudent.lastName && this.SSN == checkStudent.SSN)
                {
                    result = true;
                }
            }
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() * 2;
        }

        public override string ToString()
        {
            return string.Format("Student:{0} {3} {1}\nSSN: {2}  MobilePhone: {5}  Email: {6}\n {7} {8} {9}\n address: {4}", 
                this.firstName, this.lastName, this.SSN, this.middleName, 
                this.Address, this.MobilePhone, this.E_Mail, this.University, 
                this.Faculty, this.Speciality);
        }                                                                                                                 
        public static bool operator ==(Student left, Student right)                                                         
        {                                                                                                                  
            if (left.Equals(right))                                                                                         
            {                                                                                                             
                return true;
            }
            return false;
        }

        public static bool operator !=(Student left, Student right)
        {
            if (left.Equals(right))
            {
                return false;
            }
            return true;
        }
        
        public int CompareTo(Student other)
        {
            int result = 0;
            
            if (this.firstName[0] > other.firstName[0])
            {
                result = 1;
            }
            else if (this.firstName[0] < other.firstName[0])
            {
                result = -1;
            }
            else
            {
                if (this.lastName[0] > other.lastName[0])
                {
                    result = 1;
                }
                else if (this.lastName[0] < other.lastName[0])
                {
                    result = -1;
                }
                else
                {
                    if (this.SSN[0] > other.SSN[0])
                    {
                        result = 1;
                    }
                    else if (this.SSN[0] < other.SSN[0])
                    {
                        result = -1;
                    }
                    else
                    {
                        result = 0;
                    }
                }
            }

            return result;
        }

        public object Clone()
        {
            Student cloneStudent = new Student(this.firstName, this.lastName, this.SSN);
            cloneStudent.MiddleName = this.MiddleName;
            cloneStudent.Address = this.Address;
            cloneStudent.MobilePhone = this.MobilePhone;
            cloneStudent.E_Mail = this.E_Mail;
            cloneStudent.University = this.University;
            cloneStudent.Faculty = this.Faculty;
            cloneStudent.Speciality = this.Speciality;
            return cloneStudent;
        }

        public string GetNameSSN()
        {
            return string.Format("{0,-10} {1,-10}  SSN: {2,-10}  ",
               this.firstName,  this.lastName, this.SSN);
        }
    }
}
