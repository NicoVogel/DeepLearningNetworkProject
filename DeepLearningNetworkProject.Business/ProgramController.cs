
using System;
using System.Collections.Generic;
using DLNP.Entities.Interfaces.Business;
using DLNP.Entities.Interfaces.Data;
using DLNP.Entities.Interfaces.Factories;
using DLNP.Entities.Interfaces.Business.Models;

namespace DLNP.Business
{
    public class ProgramController : IProgramController
    {

        #region Private Variables


        private IEntityFactory m_ef;
        private IBusinessFactory m_bf;
        private IList<INetworkInputData> m_data;
        private IDataManager m_dm;
        private INetwork m_net;


        #endregion

        #region Properties



        public IList<INetworkInputData> Data
        {
            get
            {
                if (m_data == null)
                    m_data = this.m_ef.CreateList<INetworkInputData>();
                return m_data;
            }
            private set
            {
                m_data = value;
            }
        }

        public INetwork Network
        {
            get { return m_net; }
            private set { m_net = value; }
        }
        
        public IDataManager DataManager
        {
            get
            {
                if (m_dm == null)
                    m_dm = this.m_bf.CreateDataManager();
                return m_dm;
            }
        }



        #endregion

        #region Constructors



        /// <summary>
        /// default constructor
        /// </summary>
        public ProgramController(IEntityFactory ef, IBusinessFactory bf)
        {
            this.m_ef = ef;
            this.m_bf = bf;
        }



        #endregion

        #region Public methods



        public IList<string> GetExtensions()
        {
            return this.DataManager.AvailiableExtensions;
        }

        public void LoadFile(string extension, string imagePath, string labelPath)
        {

            if (String.IsNullOrEmpty(extension))
                throw new ArgumentNullException(nameof(extension), "Cannot load training data with an empty file extension.");
            
            if (String.IsNullOrEmpty(imagePath))
                throw new ArgumentNullException(nameof(imagePath), "Cannot load training data with an empty image file path.");

            if (String.IsNullOrEmpty(labelPath))
                throw new ArgumentNullException(nameof(labelPath), "Cannot load training data with an empty label file path.");

            if (this.Network == null)
                throw new ArgumentNullException(nameof(this.Network), "Cannot load traing data for a network which is null.");


            var data = this.DataManager.ReadFile(extension, imagePath, labelPath);
            
        }

        public void LoadNetwork(string networkPath)
        {

            if (String.IsNullOrEmpty(networkPath))
                throw new ArgumentNullException(nameof(networkPath), "Cannot load the network from an empty path.");

            this.Network = this.DataManager.LoadNetwork(networkPath);
        }

        public void SaveNetwork(string networkPath)
        {

            if (String.IsNullOrEmpty(networkPath))
                throw new ArgumentNullException(nameof(networkPath), "Cannot save the network to an empty path.");

            if (this.Network == null)
                throw new ArgumentNullException(nameof(this.Network), "The network value is null.");
            
            this.DataManager.SaveNetwork(networkPath, this.Network);
        }

        public void StartTraining()
        {
            throw new NotImplementedException();
        }

        public void StopTraining()
        {
            throw new NotImplementedException();
        }

        public void InizialiseNetwork(IList<int> layerCount)
        {
            
             
        }



        #endregion

    }
}
