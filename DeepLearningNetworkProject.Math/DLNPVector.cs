using DLNP.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLNP.Math
{
    public class DLNPVector : IVector
    {
        #region Private Values

        private double[] m_components;

        #endregion


        #region Public Properties

        public double this[int index]
        {
            get
            {
                return m_components[index];
            }

            set
            {
                m_components[index] = value;
            }
        }

        public int Size
        {
            get
            {
                return m_components.Length;
            }

            private set
            {

            }
        }

        #endregion


        #region Constructor

        public DLNPVector(params double[] args)
        {
            m_components = args;
        }

        public DLNPVector(int size)
        {
            m_components = new double[size];
        }

        #endregion


        #region Operators

        public static DLNPVector operator +(DLNPVector a, DLNPVector b)
        {
            if (a.Size == b.Size)
            {
                DLNPVector result = new DLNPVector(a.Size);

                for (int i = 0; i < a.Size; i++)
                {
                    result[i] = a[i] + b[i];
                }

                return result;
            }
            else
            {
                throw new InvalidOperationException("Vectors must be of the same size!");
            }

        }

        public static DLNPVector operator -(DLNPVector a, DLNPVector b)
        {
            if (a.Size == b.Size)
            {
                DLNPVector result = new DLNPVector(a.Size);

                for (int i = 0; i < a.Size; i++)
                {
                    result[i] = a[i] - b[i];
                }

                return result;
            }
            else
            {
                throw new InvalidOperationException("Vectors must be of the same size!");
            }

        }

        /// <summary>
        /// Dot product of two vectors
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator *(DLNPVector a, DLNPVector b)
        {
            if (a.Size == b.Size)
            {
                double result = 0;

                for (int i = 0; i < a.Size; i++)
                {
                    result += a[i] * b[i];
                }

                return result;
            }
            else
            {
                throw new InvalidOperationException("Vectors must be of the same size!");
            }

        }

        public static DLNPVector operator *(double scalar, DLNPVector vector)
        {
            DLNPVector result = new DLNPVector(vector.Size);

            for (int i = 0; i < vector.Size; i++)
            {
                result[i] = scalar * vector[i];
            }

            return result;
        }

        #endregion

    }
}

        
}
