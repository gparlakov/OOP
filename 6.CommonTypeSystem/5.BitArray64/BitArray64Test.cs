using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BitArray64
{
    class BitArray64Test
    {
        static void Main()
        {
            Console.WriteLine("Create an instance of BitArray64 to hold the value ot 40 000 000 000 099 999 999 and then print it on console");
            BitArray64 testArray = new BitArray64(4000000000009999999);
            foreach (var item in testArray)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Create an instance of BitArray64LinkedList to hold the previously created BitArray64 value" );
            BitArray64LinkedList<BitArray64> list = new BitArray64LinkedList<BitArray64>(testArray);
            //foreach of the linked list items foreach of the bits of the BitArray64
            foreach (var item in list)
            {
                foreach (var bit in item)
                {
                    Console.Write(bit);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("add few items to the created list\n");
            list.Add(new BitArray64(15));
            list.Add(new BitArray64(1676768867785));
            list.Add(new BitArray64(199999999995));
            list.Add(new BitArray64(133333333333335));
           
            foreach (var item in list)
            {
                Console.Write("Next BitArray64: ");
                foreach (var bit in item)
                {
                    Console.Write(bit);
                }
                Console.WriteLine(" = {0} ",item.Value);
            }
        }
    }
}
