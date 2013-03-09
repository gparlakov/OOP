/*We are given a school. In the school there are classes of students. Each class has a set of  * teachers. Each teacher teaches a set of disciplines. Students have name and unique class number.  * Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number  * of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional  * comments (free text block).	Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, 
 * define the class hierarchy and create a class diagram with Visual Studio*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    class SchoolTest
    {
        static void Main()
        {
            Teacher Jekov = new Teacher("Professor", "Jekov", 28, new List<Disciplines>() { Disciplines.CSS,
                Disciplines.JavaScriptPartI});
            Teacher Niki = new Teacher("Nikolay", "Kostov", 23, new List<Disciplines>() { Disciplines.CSharpPartI, 
                Disciplines.CSharpPartII, Disciplines.OOP });
            Teacher Joro = new Teacher("Georgi", "Georgiev", 22, new List<Disciplines>() { Disciplines.CSharpPartI,
                Disciplines.CSharpPartII, Disciplines.OOP,Disciplines.JavaScriptPartI });
            ICollection<Teacher> class2Teachers = new List<Teacher>()
            {
                Niki,
                Joro
            };
            
            ICollection<DisciplinesStruct> classIDisciplines = new List<DisciplinesStruct>();
           
            classIDisciplines.Add(new DisciplinesStruct(Disciplines.CSharpPartII, 7, 8));
            classIDisciplines.Add(new DisciplinesStruct(Disciplines.CSharpPartI, 8, 9));
            classIDisciplines.Add(new DisciplinesStruct(Disciplines.CSS, 5, 5));
            classIDisciplines.Add(new DisciplinesStruct(Disciplines.HTML, 4, 5));
            
            Student gosho = new Student("Georgi", "Georgiev", 25, "ra78909");
            gosho.AddComment("Just terrible");
            Student pesho = new Student("Petar", "Angelov", 25, "ra78669");
            Student jeko = new Student("Jivko", "Stoqnov", 25, "rb70015");

            ICollection<Student> studentsInClassII = new List<Student>()
            {
                gosho,
                pesho,
                jeko,
                new Student("Maria","Stoqnova",24,"rf12345")                
            };


            SchoolClass classI = new SchoolClass("Class I - Pioneer");
            classI.Disciplines = classIDisciplines;
            classI.AddStudent(gosho);            
            classI.AddStudent(jeko);
            classI.AddTeacher(Jekov);
            classI.RemoveDiscipline(Disciplines.CSharpPartII);
            classI.RemoveDiscipline(Disciplines.CSharpPartI);            

            SchoolClass classII = new SchoolClass("Class II - Panters", studentsInClassII, classIDisciplines,class2Teachers);
            classII.AddComment("Very good class");

            Console.WriteLine(classI);
            Console.WriteLine(classI.TextComment);
            Console.WriteLine();
            Console.WriteLine(classII);
            Console.WriteLine(classII.TextComment);
        }
    }
}
