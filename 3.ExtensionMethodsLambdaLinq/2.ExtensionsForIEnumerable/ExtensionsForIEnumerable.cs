using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionsForIEnumerable
{   

    static class ExtensionsForIEnumerable
    {
        /// <summary>
        /// My implementation of Sum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            try
            {

                T result = default(T);
                foreach (var item in collection)
                {
                    result += ((dynamic)result + (dynamic)item);
                }
                return result;
            }
            catch (Exception)
            {
                throw new ExtensionException(String.Format("The type {0} doesn't have operator + so the sum can't be calculated", typeof(T)));
            }
        }

        /// <summary>
        /// My implementation of Min
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = default(T);

            //take the first member of collection
            foreach (var item in collection)
            {
                min = item;
                break;
            }

            foreach (var item in collection)
            {
                if (min.CompareTo(item) >= 0)
                {
                    min = item;
                }
            }

            return min;
        }

        /// <summary>
        /// My implementation of Max
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T max = default(T);

            //take the first member of collection
            foreach (var item in collection)
            {
                max = item;
                break;
            }

            foreach (var item in collection)
            {
                if (max.CompareTo(item) <= 0)
                {
                    max = item;
                }
            }
            return max;
        }

        /// <summary>
        /// My implementation of Average
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static T Average<T>(this IEnumerable<T> collection)
        {
            try
            {
                int counter = 0;
                foreach (var item in collection)
                {
                    counter++;
                }
                return (dynamic)Sum<T>(collection) / counter;
            }
            catch (Exception)
            {
                throw new ExtensionException(String.Format("The type {0} doesn't have operator / so the average can't be calculated ", typeof(T)));
            }
        }

        
    }
}
