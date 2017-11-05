using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLNP.Entities.Interfaces
{
    interface IDLNPVector
    {
        /// <summary>
        /// Indexer to get vector components
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        double this[int index] { get; set; }

        /// <summary>
        /// Number of components this vector contains
        /// </summary>
        int Size { get; }
    }
}
