using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Data
{
    public interface INetworkInputData
    {
        /// <summary>
        /// The number which is represented by the image
        /// </summary>
        int ExpectedResult { get; set; }

        /// <summary>
        /// Contains the value for each pixel
        /// </summary>
        double[][] ImageNumbers { get; set; }

        /// <summary>
        /// Creates the array with the correct size
        /// </summary>
        /// <param name="rows">row count -> the first number</param>
        /// <param name="columns">column count -> the second number</param>
        void initDoubleArray(int rows, int columns);

    }
}
