
using DLNP.Entities.Interfaces.Data;

namespace DLNP.Entities.Models
{
    public class NetworkInputData : INetworkInputData
    {

        #region Properties



        public int ExpectedResult { get; set; }

        public double[][] ImageNumbers { get; set; }



        #endregion

        #region Constructor



        /// <summary>
        /// default constructor
        /// </summary>
        public NetworkInputData()
        {

        }



        #endregion

        #region Public Methods



        /// <summary>
        /// creates the array with the correct size
        /// </summary>
        /// <param name="rows">row count -> the first number</param>
        /// <param name="columns">column count -> the second number</param>
        public void initDoubleArray(int rows, int columns)
        {
            this.ImageNumbers = new double[rows][];
            for (int i = 0; i < this.ImageNumbers.Length; ++i)
                this.ImageNumbers[i] = new double[columns];
        }

        #endregion
    }
}
