using DLNP.Entities.Interfaces.Data;
using DLNP.Entities.Models;
using System.Collections.Generic;

namespace DLNP.Entities.Factory
{
    public static class BasicFactory
    {
        /// <summary>
        /// create a new <see cref="List{T}"/> object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IList<T> CreateList<T>()
        {
            return new List<T>();
        }

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
