
using DLNP.Entities.Interfaces.Data;
using DLNP.Entities.Interfaces.Factories;
using DLNP.Data;
using DLNP.Entities.Interfaces.Factories.Connection;
using DLNP.Data.Factory;

namespace DLNP.Business.Factory
{
    public class BusinessFactory : IBusinessFactoryExtension
    {

        #region Private Variables


        private IDataFactoryExtension m_dfe;


        #endregion

        #region Properties



        public IDataFactoryExtension DataFactory
        {
            get
            {
                if (m_dfe == null)
                    m_dfe = new DataFactory();
                return m_dfe;
            }
        }

        public IEntityFactory EntityFactory
        {
            get { return this.DataFactory.EntityFactory; }
        }


        #endregion

        #region Constructor



        /// <summary>
        /// default consturctor
        /// </summary>
        public BusinessFactory()
        {
        }



        #endregion


        public IDataManager CreateDataManager()
        {
            return new DataManager(this.DataFactory);
        }
    }
}
