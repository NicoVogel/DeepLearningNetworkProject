using DLNP.Entities.Interfaces.Data;
using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Factories
{
    public interface IDataFactory
    {

        /// <summary>
        /// Get a instance of all IFileReader
        /// </summary>
        /// <returns></returns>
        IList<IFileReader> GetAllFileReader();

        /// <summary>
        /// Create a new <see cref="NetworkFileManager"/> object
        /// </summary>
        /// <returns></returns>
        INetworkFileManager CreateNetworkFileManager();

        /// <summary>
        /// create a new instance of a <see cref="IDataManager"/> object
        /// </summary>
        /// <returns></returns>
        IDataManager CreateDataManager();
    }
}
