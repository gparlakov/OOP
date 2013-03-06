/*
3.Write a method that from a given array of students finds all students whose 
* first name is before its last name alphabetically. Use LINQ query operators.
4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first 
* name and last name in descending order. Rewrite the same with LINQ.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsSearch
{

    class StudentsSearch
    {
        static void Main()
        {
            ICollection<Student> students = new List<Student> { new Student("Pesho","Ivanov",22), 
                                                                new Student("Ivan","Ivanov",19),
                                                                new Student("Pesho","Atanasov",25),
                                                                new Student("Atanas","Petrov",30),
                                                                new Student("Gylyb","Ivanov",40),
                                                                new Student("Pesho","Unov",19),
                                                                new Student("Pesho","Ivanov",24),
                                                                new Student("Qnaki","Stoqnov",22),
                                                                new Student("Qnaki","Qnaki",21),
                                                                new Student("Atanas","Qnakiev",59),
                                                                new Student("Qnaki","Zerov",16),
                                                                new Student("Pesho","Ivanov",21), 
                                                                new Student("Atanas","Qnakiev",19),
                                                              };

            //task 3
            var selection = from st in students
                            where st.FirstName.CompareTo(st.LastName) < 0
                            orderby st.FirstName                            
                            select st;
           
            PrintCollection(selection, "\nSelect by first name > last name (alphbetically)\n------------");

            //task 4
            var ageSelection = from st in students
                               where (st.Age > 18 && st.Age < 24)
                               orderby st.LastName
                               select st;
           
            PrintCollection(ageSelection, "\nSelect by: 24 > age >18  \n------------");  
         
            //task 5 LINQ
            var nameSelectionOrdered = from st in students
                                       orderby st.FirstName,st.LastName                                       
                                       select st;

            PrintCollection(nameSelectionOrdered, "\nOrder by first name, last name  LINQ\n------------");

            //task 5 w/o LINQ
            students = students.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ThenBy(x => x.Age).ToList();
            PrintCollection(students, "\nOrder by first name, last name w/o LINQ\n------------");
        }
  
        private static void PrintCollection(IEnumerable<Student> ageSelection,string message)
        {
            Console.WriteLine(message);
            foreach (var student in ageSelection)
            {
                Console.WriteLine(student);
            }
        }
    }
}
