/*Write a program that prints from given array of integers all numbers that
 * are divisible by 7 and 3. Use the built-in extension methods and lambda 
 * expressions. Rewrite the same with LINQ.*/

using System;
using System.Collections.Generic;
using System.Linq;


namespace DevisibleBy5And7
{
    class DevisibleBy5And7Test
    {
        static void Main()
        {
            int[] aGivenArray = new int[] {30,3,35,135,140,150,70,350,352,425,700};

            var lambdaSelection = aGivenArray.Select(num =>
                {
                    if (num % 5 == 0 && num % 7 == 0)
                        return num;
                    else return -1;
                }).Where(num => num > 0);

            // OR JUST

            var labdaSelShorter = aGivenArray.Where(num => num % 5 == 0 && num % 7 == 0).OrderBy(num=>num);
            
            var LINQSelection = from num in aGivenArray
                                where num % 5 == 0 && num % 7 == 0
                                orderby num descending
                                select num;

            PrintCollection(lambdaSelection, "Labda selection");
            PrintCollection(labdaSelShorter, "Labda selection shorter ascending");
            PrintCollection(LINQSelection, "LINQ selection descending");
            

            
        }
  
        private static void PrintCollection(IEnumerable<int> collection,string message)
        {
            Console.WriteLine("-----------\n" + message);
            foreach (var num in collection)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
