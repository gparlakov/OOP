/*Define a class InvalidRangeException<T> that holds information about an error * condition related to invalid range. It should hold error message and a range definition [start … end].Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
 * by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].*/

using System;
using System.Linq;

namespace InvalidRangeExceptionGeneric
{
    class StartPoint
    {
        static void Main()
        {
            try
            {
                int number;
                DateTime date,
                        startDate = new DateTime(1980, 1, 1),
                        endDate = new DateTime(2013, 12, 31);
                string[] dateString;

                Console.WriteLine("Give me an int 1 to 100:");
                number = int.Parse(Console.ReadLine());
                if (number <= 0 || number > 100)
                {
                    throw new InvalidRangeException<int>(1, 100);
                }

                Console.WriteLine("Give me a date range [1.1.1980 … 31.12.2013] in the format dd.mm.yyyy:");
                dateString = Console.ReadLine().Split(new char[] { ',', '.', '/', ' ', '\\', '|' }, StringSplitOptions.RemoveEmptyEntries); // separators just in case
                date = new DateTime(int.Parse(dateString[2]), int.Parse(dateString[1]), int.Parse(dateString[0]));
                if (date < startDate || date > endDate)
                {
                    throw new InvalidRangeException<DateTime>(startDate, endDate);
                }

                Console.WriteLine("Number is {0} date is {1}",number,date);

            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
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
