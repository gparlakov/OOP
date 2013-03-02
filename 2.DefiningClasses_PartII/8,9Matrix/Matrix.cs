using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix 
{
    class Matrix<T>
        where T : IComparable, IConvertible      
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int columns)
        {
            this.matrix = new T[rows, columns];
            this.rows = rows;
            this.cols = columns;
        }
       
        public T this[int row, int col]
        {
            get
            {
                if (!IsInside(row, col))
                {
                    this.ExceptionMethod();
                }
                return this.matrix[row, col];
            }
            set
            {
                if (!IsInside(row, col))
                {
                    this.ExceptionMethod();
                }
                this.matrix[row, col] = value;
            }
        }

        /// <summary>
        /// Check if index is inside matrix
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        private bool IsInside(int row, int col)
        {
            bool isInside = true;
            if (row < 0 || row >= this.rows || col < 0 || col >= this.cols)
            {
                isInside = false;
            }
            return isInside;
        }

        /// <summary>
        /// Throws exception when argument is outside boundaries of collection
        /// </summary>
        private void ExceptionMethod()
        {
            throw new ArgumentOutOfRangeException(string.Format("Index is outside of boundaries of Matrix."));
        }

        public static T[,] operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.rows != second.rows || first.cols != second.cols)
            {
                throw new ArgumentOutOfRangeException(string.Format("Index is outside of boundaries of Matrix."));
            }
            Matrix<T> resultMatrix = new Matrix<T>(first.rows, first.cols);
            for (int row = 0; row < resultMatrix.rows; row++)
            {
                for (int col = 0; col < resultMatrix.cols; col++)
                {
                    resultMatrix[row, col] = first[row, col] + second[row, col];
                }
            }
        }
    }
}
