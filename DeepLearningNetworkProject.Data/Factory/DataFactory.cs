
using DLNP.Data.MNIST;
using DLNP.Data.Network;
using DLNP.Entities.Interfaces.Data;
using DLNP.Entities.Interfaces.Factories;
using System.Collections.Generic;

namespace DLNP.Data.Factory
{
    public class DataFactory : IDataFactory
    {

        #region Private variables



        private IEntityFactory m_ef;



        #endregion

        #region Properties



        public IEntityFactory EntityFactory
        {
            get { return m_ef; }
        }



        #endregion

        #region Constructor



        /// <summary>
        /// default constructor
        /// </summary>
        public DataFactory(IEntityFactory ef)
        {
            this.m_ef = ef;
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
        
        public IDataManager CreateDataManager()
        {
            return new DataManager(this);
        }

    }
}
