using DLNP.Entities.Interfaces.Business.Models;
using System;

namespace DLNP.Math
{
    public class DLNPMatrix : IMatrix
    {
        #region Private Values

        private double[,] m_components;

        #endregion

        #region Public Properties

        public double this[int m, int n]
        {
            get
            {
                return m_components[m, n];
            }

            set
            {
                m_components[m, n] = value;
            }
        }

        public int Rows { get => m_components.GetLength(0); }

        public int Columns { get => m_components.GetLength(1); }

        #endregion

        #region Constructor

        public DLNPMatrix(int rows, int columns)
        {
            m_components = new double[rows, columns];
        }

        #endregion

        #region Operators

        /// <summary>
        /// Multiplication of two matrices.
        /// Colum size from matrix a must equal row size from matrix b.
        /// Row size from matrix a must equal column size from matrix b.
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="b">Second matrix</param>
        /// <returns>A matrix with row size of matrix a and column size of matrix b</returns>
        public static DLNPMatrix operator *(DLNPMatrix a, DLNPMatrix b)
        {
            if(a.Columns == b.Rows && a.Rows == b.Columns)
            {
                DLNPMatrix result = new DLNPMatrix(a.Rows, b.Columns);

                for(int m = 0; m < a.Rows; m++)
                {
                    for(int n = 0; n < b.Columns; n++)
                    {
                        for(int i = 0; i < a.Columns; i++)
                        {
                            result[m, n] += a[m, i] * b[i, n];
                        }
                    }
                }

                return result;
            }
            else
            {
                throw new InvalidOperationException("Matrices are not compatible!");
            }
        }

        /// <summary>
        /// Multiplication of matrix and vector. Vector size must be equal to matrix columns.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Vector modified by a matrix</returns>
        public static DLNPVector operator *(DLNPMatrix a, DLNPVector b)
        {
            if(a.Columns == b.Size)
            {
                DLNPVector result = new DLNPVector(b.Size);

                for(int m = 0; m < b.Size; m++)
                {
                    for(int i = 0; i < b.Size; i++)
                    {
                        result[m] += a[m, i] * b[i];
                    }
                }

                return result;
            }
            else
            {
                throw new InvalidOperationException("Matrix and vector size are not compatible!");
            }
        }

        #endregion
    }
}
