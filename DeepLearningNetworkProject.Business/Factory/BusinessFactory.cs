
using DLNP.Entities.Interfaces.Factories;
using DLNP.Entities.Interfaces.Factories.Connection;
using DLNP.Data.Factory;
using DLNP.Math.Factory;
using DLNP.Entities.Factory;
using DLNP.Entities.Interfaces.Business;

namespace DLNP.Business.Factory
{
    public class BusinessFactory : IBusinessFactoryExtension
    {

        #region Private Variables


        private IDataFactory m_dfe;
        private IEntityFactory m_ef;
        private IMathFactory m_mf;
        private IProgramController m_programController;


        #endregion

        #region Properties



        public IDataFactory DataFactory
        {
            get
            {
                if (m_dfe == null)
                    m_dfe = new DataFactory(this.EntityFactory);
                return m_dfe;
            }
        }

        public IEntityFactory EntityFactory
        {
            get
            {
                if (m_ef == null)
                    m_ef = new EntityFactory(this.MathFactory);
                return m_ef;
            }
        }

        public IMathFactory MathFactory
        {
            get
            {
                if (m_mf == null)
                    m_mf = new MathFactory();
                return m_mf;
            }
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



        public IProgramController CreateProgramController()
        {
            if(m_programController == null)
                m_programController = new ProgramController(this.EntityFactory, this, this.DataFactory);

            return m_programController;
        }

    }
}
