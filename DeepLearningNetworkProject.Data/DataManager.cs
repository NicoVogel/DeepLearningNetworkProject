using System;
using System.Collections.Generic;
using DLNP.Entities.Interfaces.Data;
using System.Linq;
using DLNP.Factory;
using DLNP.Entities.Interfaces.Business.Models;
using DLNP.Entities.Interfaces.Factories;

namespace DLNP.Data
{
    public class DataManager : IDataManager
    {

        #region Private Varaibles


        private IDataFactory m_df;
        private IList<IFileReader> m_fileReader;
        private INetworkFileManager m_nwtFileMgr;


        #endregion

        #region Properties



        public IList<string> AvailiableExtensions
        {
            get
            {
                return FileReader.Select(x => x.Extension).ToList();
            }
        }

        public IList<IFileReader> FileReader
        {
            get
            {
                if (m_fileReader == null)
                    m_fileReader = m_df.GetAllFileReader();
                return m_fileReader;
            }
        }

        public INetworkFileManager NetworkFileMgr
        {
            get
            {
                if (m_nwtFileMgr == null)
                    m_nwtFileMgr = m_df.CreateNetworkFileManager();
                return m_nwtFileMgr;
            }
        }




        #endregion

        #region Constructor



        /// <summary>
        /// default constructor
        /// </summary>
        public DataManager(IDataFactory df)
        {
            this.m_df = df;
        }


        #endregion

        #region Public Methods



        public IList<INetworkInputData> ReadFile(string extension, string imagePath, string labelPath)
        {
            var fileReader = this.FileReader.Where(x => x.Extension.Equals(extension)).FirstOrDefault();
            if (fileReader == null)
                throw new ArgumentException(String.Format("There is no implementation for the given extension: '{0}'", extension));

            return fileReader.ReadFile(imagePath, labelPath);
        }


        public INetwork LoadNetwork(string networkPath)
        {
            return this.NetworkFileMgr.LoadNetwork(networkPath);
        }


        public void SaveNetwork(string networkPath, INetwork network)
        {
            this.NetworkFileMgr.SaveNetwork(networkPath, network);
        }


        #endregion


    }
}
