
using DLNP.Entities.Interfaces.Business;
using DLNP.Entities.Interfaces.Factories;
using DLNP.Business.Factory;
using DLNP.Entities.Interfaces.Factories.Connection;
using DLNP.Business;

namespace DLNP.Factory
{
    public class PresentationFactory : IPresentationFactory
    {
        #region Private Variables


        private IBusinessFactoryExtension m_bf;


        #endregion

        #region Properties



        public IBusinessFactoryExtension BusinessFactory
        {
            get
            {
                if (m_bf == null)
                    m_bf = new BusinessFactory();
                return m_bf;
            }
        }

        public IEntityFactory EntityFactory
        {
            get { return this.BusinessFactory.EntityFactory; }
        }

        public IDataFactory DataFactory
        {
            get { return this.BusinessFactory.DataFactory; }
        }


        #endregion

        #region Constructor



        /// <summary>
        /// default consturctor
        /// </summary>
        public PresentationFactory()
        {

        }



        #endregion

        public IProgramController CreateProgramController()
        {
            return new ProgramController(this.EntityFactory, this.DataFactory);
        }
    }
}
