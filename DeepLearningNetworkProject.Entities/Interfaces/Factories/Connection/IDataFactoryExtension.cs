

namespace DLNP.Entities.Interfaces.Factories.Connection
{
    public interface IDataFactoryExtension : IDataFactory
    {

        /// <summary>
        /// Connection to Entity Factory
        /// </summary>
        IEntityFactory EntityFactory { get; }
    }
}
