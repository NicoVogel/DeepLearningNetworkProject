
using DLNP.Entities.Interfaces.Data;
using System;
using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Business
{
    public interface IProgramController
    {

        /// <summary>
        /// The training data
        /// </summary>
        IList<INetworkInputData> Data { get; }

        /// <summary>
        /// Get all availiable file extensions
        /// </summary>
        /// <returns></returns>
        IList<String> GetExtensions();

        /// <summary>
        /// Load training data into the system
        /// </summary>
        /// <param name="imagePath"></param>
        /// <param name="labelPath"></param>
        void LoadFile(String extension, String imagePath, String labelPath);

        /// <summary>
        /// Save the current state of the network without the training data
        /// </summary>
        /// <param name="networkPath"></param>
        void SaveNetwork(String networkPath);

        /// <summary>
        /// Load a network from a file
        /// </summary>
        /// <param name="networkPath"></param>
        void LoadNetwork(String networkPath);

        /// <summary>
        /// Start the training process
        /// </summary>
        void StartTraining();

        /// <summary>
        /// Stop the training process
        /// </summary>
        void StopTraining();

        /// <summary>
        /// creates a new network with random numbers
        /// </summary>
        /// <param name="layerCount">the list length is the layer count and each value is the amount of nodes per layer</param>
        void InizialiseNetwork(IList<int> layerCount);

    }
}
