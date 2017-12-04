
using DLNP.Entities.Interfaces.Factories;
using DLNP.Business.Factory;
using DLNP.Entities.Interfaces.Factories.Connection;
using DLNP.Entities.Interfaces.Business;

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
            return this.BusinessFactory.CreateProgramController();
        }
    }
}
