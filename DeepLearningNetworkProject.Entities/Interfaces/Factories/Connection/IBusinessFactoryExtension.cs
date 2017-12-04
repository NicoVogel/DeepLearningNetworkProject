

namespace DLNP.Entities.Interfaces.Factories.Connection
{
    public interface IBusinessFactoryExtension : IBusinessFactory
    {

        /// <summary>
        /// Connection to the data factory
        /// </summary>
        IDataFactory DataFactory { get; }

        /// <summary>
        /// Connection to the entity factory
        /// </summary>
        IEntityFactory EntityFactory { get; }
    }
}
