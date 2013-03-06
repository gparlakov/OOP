/*Implement a set of extension methods for IEnumerable<T> that
 * implement the following group functions: sum, product, min, max, average.*/

using System;
using System.Collections.Generic;

namespace ExtensionsForIEnumerable
{
    class ExtensionsForIEnumerableTest
    {     
        static void Main()
        {
            try
            {
                List<float> myList = new List<float>();
                myList.AddRange(new float[] { 5, 6, -7.7f, 1.1f });
                float checker = myList.Sum<float>();
                Console.WriteLine(checker);

                Console.WriteLine(myList.Min<float>());

                Console.WriteLine(myList.Average<float>());


                List<DateTime> myListDateTime = new List<DateTime>();
                myListDateTime.AddRange(new DateTime[] { new DateTime(599999991000040000), new DateTime(599999991100000000), new DateTime(559999999990000000) });

                // ;)
                //foreach (var date in myListDateTime)
                //{
                //    Console.WriteLine(date);
                //}
                // throw exception
                //Console.WriteLine(myListDateTime.Sum());
                //Console.WriteLine(myListDateTime.Average<DateTime>());                

            }
            catch (ExtensionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
