

using DLNP.Data.MNIST;
using DLNP.Data.Network;
using DLNP.Entities.Factory;
using DLNP.Entities.Interfaces.Data;
using System.Collections.Generic;

namespace DLNP.Factory
{
    public static class DataLayerFactory
    {
        /// <summary>
        /// Get a instance of all IFileReader
        /// </summary>
        /// <returns></returns>
        public static IList<IFileReader> GetAllFileReader()
        {
            var list = BasicFactory.CreateList<IFileReader>();
            list.Add(new MnistFileReader());
            return list;
        }

        /// <summary>
        /// Create a new <see cref="NetworkFileManager"/> object
        /// </summary>
        /// <returns></returns>
        public static INetworkFileManager CreateNetworkFileManager()
        {
            return new NetworkFileManager();
        }
    }
}
