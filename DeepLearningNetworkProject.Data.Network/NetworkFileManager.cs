
using System;
using DLNP.Entities.Interfaces.Business.Models;
using DLNP.Entities.Interfaces.Data;
using Newtonsoft.Json;
using System.IO;

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
            INetwork network = null;
            try
            {
                using (StreamReader sr = new StreamReader(networkPath))
                {
                    string json = sr.ReadToEnd();
                    network = JsonConvert.DeserializeObject<INetwork>(json);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(String.Format("Failed to load a network json file with the path: {0}, message: {1}", networkPath, ex.Message), ex);
            }

            return network;
        }

        public void SaveNetwork(string networkPath, INetwork network)
        {
            try
            {
                string json = JsonConvert.SerializeObject(network);
                File.WriteAllText(networkPath, json);
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Failed to save a network json file to the path: {0}, message: {1}", networkPath, ex.Message), ex);
            }
        }



        #endregion
    }
}
