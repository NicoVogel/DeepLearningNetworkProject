

using DLNP.Entities.Interfaces.Business.Models;
using System;

namespace DLNP.Entities.Interfaces.Data
{
    public interface INetworkFileManager
    {

        /// <summary>
        /// The extension of the file which contains the network
        /// </summary>
        String Extension { get; set; }

        /// <summary>
        /// Load a network file
        /// </summary>
        /// <param name="networkPath"></param>
        /// <returns></returns>
        INetwork LoadNetwork(String networkPath);

        /// <summary>
        /// Save a network file
        /// </summary>
        /// <param name="networkPath"></param>
        /// <param name="network"></param>
        void SaveNetwork(String networkPath, INetwork network);

    }
}
