using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong bitValue;

        public ulong BitValue
        {
            get { return bitValue; }
            set { bitValue = value; }
        }

        public BitArray64(ulong value)
        {
            this.bitValue = value;
        }


        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
