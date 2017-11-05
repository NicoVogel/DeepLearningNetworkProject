using System;
using System.Collections.Generic;
using DLNP.Entities.Interfaces.Data;
using System.Linq;
using DLNP.Factory;

namespace DLNP.Data
{
    public class DataManager : IDataManager
    {

        #region Private Varaibles


        private IList<IFileReader> m_fileReader;


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
                    m_fileReader = DataLayerFactory.GetAllFileReader();
                return m_fileReader;
            }
        }




        #endregion

        #region Constructor



        /// <summary>
        /// default constructor
        /// </summary>
        public DataManager()
        {
                
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


        #endregion


    }
}
