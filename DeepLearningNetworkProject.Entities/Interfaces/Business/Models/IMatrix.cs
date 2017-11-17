
namespace DLNP.Entities.Interfaces.Business.Models
{
    public interface IMatrix
    {
        /// <summary>
        /// Indexer to get the matrix components
        /// </summary>
        /// <param name="m">row</param>
        /// <param name="n">column</param>
        /// <returns>Value of the specified matrix cell</returns>
        double this[int m, int n] { get; set; }

        /// <summary>
        /// Number of rows in this matrix
        /// </summary>
        int Rows { get; }

        /// <summary>
        /// Number of columns in this matrix
        /// </summary>
        int Columns { get; }
    }
}
