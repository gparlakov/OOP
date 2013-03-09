/*Define abstract class Human with first name and last name. Define new class 
 * Student which is derived from Human and has new field – grade. Define class 
 * Worker derived from Human with new property WeekSalary and WorkHoursPerDay and
 * method MoneyPerHour() that returns money earned by hour by the worker. Define the 
 * proper constructors and properties for this hierarchy. Initialize a list of 10 students 
 * and sort them by grade in ascending order (use LINQ or OrderBy() extension method). Initialize
 * a list of 10 workers and sort them by money per hour in 
 * descending order. Merge the lists and sort them by first name and last name.*/

using System;
using System.Linq;
using System.Collections.Generic;


namespace Human
{
    class HumanTest
    {
        static void Main()
        {            
            ICollection<Student> studentsList = new List<Student>(){
                new Student("Petar","Petrov",6f),
                new Student("Ivan","Georgiev",7.6f),
                new Student("Hitar","Petar",33),
                new Student("Georgi","Ivanov",76.7f),
                new Student("Qnaki","Petrov",76.8f),
                new Student("Radka","Radeva",66),
                new Student("Petrana","Qnakaieva",56.6f),
                new Student("Petar","Stiolov",34.4f),
                new Student("Maria","Petrova",13),
                new Student("Ivana","Trump",6)
            };

            ICollection<Worker> workerList = new List<Worker>(){
                new Worker("Georgi","Ivanov",350,5),
                new Worker("Ivan","Radoev",235,7),
                new Worker("Nikolina","Chakardakova",550,4),
                new Worker("Svetlin","Nakov",1000,10),
                new Worker("Nikolay","Kostov",2000,15),
                new Worker("Georgi","Nikolov",567,4),
                new Worker("Ivelina","Haralanova",390,9),
                new Worker("Hristina","Ivanova",2500,4),
                new Worker("Qnaki","Qnakiev",150,15),
                new Worker("Money","Maker",155,1),
            };
            
            studentsList = studentsList.OrderBy(x => x.Grade).ToList();

            var workerListLINQ = from worker in workerList
                                    orderby worker.MoneyPerHour() descending
                                        select worker;

            ICollection<Human> mergedList = new List<Human>();
            //add and write the list on the console
            Console.WriteLine("Students sorted by GRADE :");
            foreach (var item in studentsList)
            {
                mergedList.Add(item);
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\nWorkers sorted by MONEY Per/H ");
            foreach (var item in workerListLINQ)
            {
                mergedList.Add(item);
                Console.WriteLine(item.ToString());
            }            

            var mergedSorted = from human in mergedList
                               orderby human.FirstName, human.LastName
                               select human;
            Console.WriteLine("\nHumans sorted by first name and last name lexicographically");
            foreach (var human in mergedSorted)
            {
                Console.WriteLine(human.ToString());
            } 
        }
    }
}
