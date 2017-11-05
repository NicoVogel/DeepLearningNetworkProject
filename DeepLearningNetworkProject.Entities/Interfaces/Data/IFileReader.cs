
using System;
using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Data
{
    public interface IFileReader
    {

        /// <summary>
        /// get the extension which can be read with this FileReader
        /// </summary>
        String Extension { get; }

        /// <summary>
        /// read the file data from the given paths
        /// </summary>
        /// <param name="imagesPath"></param>
        /// <param name="lablesPath"></param>
        /// <returns></returns>
        IList<INetworkInputData> ReadFile(String imagesPath, String lablesPath);

    }
}
