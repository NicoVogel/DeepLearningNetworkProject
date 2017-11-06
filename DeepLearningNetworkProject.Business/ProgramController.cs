
using System;
using System.Collections.Generic;
using DLNP.Entities.Interfaces.Business;
using DLNP.Entities.Interfaces.Data;
using DLNP.Entities.Interfaces.Factories;

namespace DLNP.Business
{
    public class ProgramController : IProgramController
    {

        #region Private Variables


        private IEntityFactory m_bf;
        private IDataFactory m_df;
        private IList<INetworkInputData> m_data;
        private IDataManager m_dm;


        #endregion

        #region Properties



        public IList<INetworkInputData> Data
        {
            get
            {
                if (m_data == null)
                    m_data = m_bf.CreateList<INetworkInputData>();
                return m_data;
            }
        }
        public IDataManager DataManager
        {
            get
            {
                return null;
            }
        }



        #endregion

        #region Constructors



        /// <summary>
        /// default constructor
        /// </summary>
        public ProgramController(IEntityFactory bf, IDataFactory df)
        {
            this.m_bf = bf;
            this.m_df = df;
        }



        #endregion

        #region Public methods



        public IList<string> GetExtensions()
        {

            throw new NotImplementedException();
        }

        public void LoadFile(string imagePath, string labelPath)
        {
            throw new NotImplementedException();
        }

        public void LoadNetwork(string networkPath)
        {
            throw new NotImplementedException();
        }

        public void SaveNetwork(string networkPath)
        {
            throw new NotImplementedException();
        }

        public void StartTraining()
        {
            throw new NotImplementedException();
        }

        public void StopTraining()
        {
            throw new NotImplementedException();
        }
        


        #endregion

    }
}
