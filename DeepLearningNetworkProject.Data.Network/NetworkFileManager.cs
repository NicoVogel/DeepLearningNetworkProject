
using System;
using DLNP.Entities.Interfaces.Business.Models;
using DLNP.Entities.Interfaces.Data;

namespace DLNP.Data.Network
{
    public class NetworkFileManager : INetworkFileManager
    {

        #region Properties




        public string Extension { get; set; }


        #endregion

        #region Constructor



        /// <summary>
        /// default constructor
        /// </summary>
        public NetworkFileManager()
        {
            this.Extension = "nwt";
        }



        #endregion

        #region Public Methods



        public INetwork LoadNetwork(string networkPath)
        {
            throw new NotImplementedException();
        }

        public void SaveNetwork(string networkPath, INetwork network)
        {
            throw new NotImplementedException();
        }



        #endregion
    }
}
