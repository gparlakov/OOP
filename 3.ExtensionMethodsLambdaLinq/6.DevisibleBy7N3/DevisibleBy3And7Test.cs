/*Write a program that prints from given array of integers all numbers that
 * are divisible by 7 and 3. Use the built-in extension methods and lambda 
 * expressions. Rewrite the same with LINQ.*/

using System;
using System.Collections.Generic;
using System.Linq;


namespace DevisibleBy3And7
{
    class DevisibleBy3And7Test
    {
        static void Main()
        {
            int[] aGivenArray = new int[1000];
            for (int i = 0; i < aGivenArray.Length; i++)
			{
                aGivenArray[i] = i;
			}

            var lambdaSelection = aGivenArray.Select(num =>
                {
                    if (num % 3 == 0 && num % 7 == 0)
                        return num;
                    else return -1;
                }).Where(num => num > 0);

            // OR JUST

            var labdaSelShorter = aGivenArray.Where(num => num % 3 == 0 && num % 7 == 0).OrderBy(num=>num);
            
            var LINQSelection = from num in aGivenArray
                                where num % 3 == 0 && num % 7 == 0
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
