using System;
using System.Collections.Generic;
using System.Linq;

namespace BitArray64
{
    class BitArray64 : IEnumerable<int>
    {
        public BitArray64(ulong value)
        {
            this.Value = value;         
        }

        public ulong Value { get; private set; }
         
        /// <summary>
        /// Return bits of the ulong value from left to rigth (from the 63-th bit to 0 bit) 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return (int)((this.Value >> i) & 1);
            }
        }
                
        public override bool Equals(object obj)
        {
            bool areEqual = true;

            if (obj is BitArray64)
            {
                for (int i = 0; i < 64; i++)
                {
                    if ((this.Value >> i & 1) != ((obj as BitArray64).Value >> i & 1))
                    {
                        areEqual = false;
                        break;
                    }
                }
            }
            else
            {
                areEqual = false;
            }

            return areEqual;            
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + this.Value.GetHashCode();
                return result;
            }
        }

        //    return bitString.ToString();
        //}
        //public override string ToString()
        //{
        //    StringBuilder bitString = new StringBuilder();
        //    for (int i = 64 - 1; i >= 0; i--)
        //    {
        //        bitString.Append((this.Value >> i) & 1);
        //    }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}