

using DLNP.Entities.Interfaces.Data;
using DLNP.Entities.Models;

namespace DLNP.Entities.Factory
{
    public static class DataLayerFactory
    {

        /// <summary>
        /// create a new <see cref="NetworkInputData"/> object
        /// </summary>
        /// <returns></returns>
        public static INetworkInputData CreateNetworkInputData()
        {
            return new NetworkInputData();
        }
    }
}
