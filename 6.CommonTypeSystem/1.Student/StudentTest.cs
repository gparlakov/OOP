using System;
using System.Collections.Generic;
using System.Linq;

namespace Student
{
    class StudentTest
    {
        static void Main()
        {
            Student gosho = new Student("Georgi", "Georgiev", "089147");
            gosho.E_Mail = "abv@abv.bg";

            Student goshoClone = (Student)gosho.Clone();
            Console.WriteLine(gosho);
            Console.WriteLine(goshoClone);
            Console.WriteLine();
            goshoClone.University = University.University_of_Sofia;

            Console.WriteLine(gosho);
            Console.WriteLine(goshoClone);

            //task 3

            List<Student> students = new List<Student>()
            {   
                new Student("Qnaki", "Qnakiev", "989147"),
                new Student("Georgi", "Georgiev", "289147"),
                gosho,
                goshoClone,
                new Student("Patar", "Petrov", "089147"),
                new Student("Georgi", "Georgiev", "189147"),               
                new Student("Petar", "Georgiev", "089147"),
                new Student("Qnaki", "Georgiev", "089147"),
                new Student("Qnaki", "Qnakiev", "089147"),                
            };

            students.Sort((x, y) => x.CompareTo(y));

            foreach (var stud in students)
            {
                Console.WriteLine(stud.GetNameSSN());
            }

        }
    }
}
