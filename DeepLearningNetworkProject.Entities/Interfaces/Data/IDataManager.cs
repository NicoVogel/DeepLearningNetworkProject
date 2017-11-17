
using DLNP.Entities.Interfaces.Business.Models;
using System;
using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Data
{
    public interface IDataManager
    {

        /// <summary>
        /// get the availiable file extensions. The extensions are the identifier to choose which FileReader should be used
        /// </summary>
        IList<String> AvailiableExtensions { get; }

        /// <summary>
        /// read the data from a given path with a spesific extension
        /// </summary>
        /// <param name="extension"></param>
        /// <param name="imagePath"></param>
        /// <param name="labelPath"></param>
        /// <returns></returns>
        IList<INetworkInputData> ReadFile(String extension, String imagePath, String labelPath);

        /// <summary>
        /// Load a network file
        /// </summary>
        /// <param name="networkPath"></param>
        /// <returns></returns>
        INetwork LoadNetwork(String networkPath);

        /// <summary>
        /// Save network
        /// </summary>
        /// <param name="networkPath"></param>
        /// <param name="network"></param>
        void SaveNetwork(String networkPath, INetwork network);
    }
}
