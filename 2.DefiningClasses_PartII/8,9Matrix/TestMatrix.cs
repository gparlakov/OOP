using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class TestMatrix
    {
        static void Main()
        {
            Matrix<int> matrix = new Matrix<int>(5, 5);
            matrix[0, 0] = 0;
            Console.WriteLine(matrix[0, 0]);
        }
    }
}
