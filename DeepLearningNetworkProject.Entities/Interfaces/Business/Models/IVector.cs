using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLNP.Entities.Interfaces.Business.Models
{
    public interface IVector
    {
        /// <summary>
        /// Indexer to get vector components
        /// </summary>
        /// <param name="index">component</param>
        /// <returns>Value of the specified vector component</returns>
        double this[int index] { get; set; }

        /// <summary>
        /// Number of components this vector contains
        /// </summary>
        int Size { get; }

        IVector Add(IVector v);
    }
}
