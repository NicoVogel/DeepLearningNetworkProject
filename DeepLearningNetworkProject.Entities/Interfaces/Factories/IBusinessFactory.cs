

using DLNP.Entities.Interfaces.Data;

namespace DLNP.Entities.Interfaces.Factories
{
    public interface IBusinessFactory
    {
        /// <summary>
        /// create a new instance of a <see cref="IDataManager"/> object
        /// </summary>
        /// <returns></returns>
        IDataManager CreateDataManager();
    }
}
