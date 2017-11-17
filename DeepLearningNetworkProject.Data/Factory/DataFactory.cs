
using DLNP.Data.MNIST;
using DLNP.Data.Network;
using DLNP.Entities.Factory;
using DLNP.Entities.Interfaces.Data;
using DLNP.Entities.Interfaces.Factories;
using DLNP.Entities.Interfaces.Factories.Connection;
using System.Collections.Generic;

namespace DLNP.Data.Factory
{
    public class DataFactory : IDataFactory, IDataFactoryExtension
    {

        #region Private variables



        private IEntityFactory m_bf;



        #endregion

        #region Properties



        public IEntityFactory EntityFactory
        {
            get
            {
                if (m_bf == null)
                    m_bf = new EntityFactory();
                return m_bf;
            }
        }



        #endregion

        #region Constructor



        /// <summary>
        /// default constructor
        /// </summary>
        public DataFactory()
        {
        }


        #endregion



        /// <summary>
        /// Get a instance of all IFileReader
        /// </summary>
        /// <returns></returns>
        public IList<IFileReader> GetAllFileReader()
        {
            var list = this.EntityFactory.CreateList<IFileReader>();
            list.Add(new MnistFileReader(this.EntityFactory));
            return list;
        }

        /// <summary>
        /// Create a new <see cref="NetworkFileManager"/> object
        /// </summary>
        /// <returns></returns>
        public INetworkFileManager CreateNetworkFileManager()
        {
            return new NetworkFileManager();
        }


    }
}
