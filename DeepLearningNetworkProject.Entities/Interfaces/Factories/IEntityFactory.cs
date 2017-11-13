using DLNP.Entities.Interfaces.Business.Models;
using DLNP.Entities.Interfaces.Data;
using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Factories
{
    public interface IEntityFactory
    {
        /// <summary>
        /// create a new <see cref="IList{T}"/> object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IList<T> CreateList<T>();

        /// <summary>
        /// create a new <see cref="INetworkInputData"/> object
        /// </summary>
        /// <returns></returns>
        INetworkInputData CreateNetworkInputData();

        /// <summary>
        /// create a new <see cref="INetwork"/> object
        /// </summary>
        /// <returns></returns>
        INetwork CreateEmptyNetwork();

        /// <summary>
        /// create a new <see cref="INode"/> object
        /// </summary>
        /// <returns></returns>
        INode CreateNode();

        /// <summary>
        /// create a new <see cref="Connection"/> object
        /// </summary>
        /// <returns></returns>
        IConnection CreateConnection();
    }
}
