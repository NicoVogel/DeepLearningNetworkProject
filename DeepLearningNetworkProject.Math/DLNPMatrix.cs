using DLNP.Entities.Interfaces.Business.Models;

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

        #endregion

        #region Constructor

        public DLNPMatrix()
        {

        }

        #endregion

        #region Operators



        #endregion
    }
}
