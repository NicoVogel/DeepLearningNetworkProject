using DLNP.Entities.Interfaces.Data;
using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Factories
{
    public interface IEntityFactory
    {
        /// <summary>
        /// create a new <see cref="List{T}"/> object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IList<T> CreateList<T>();

        /// <summary>
        /// create a new <see cref="NetworkInputData"/> object
        /// </summary>
        /// <returns></returns>
        INetworkInputData CreateNetworkInputData();
    }
}
