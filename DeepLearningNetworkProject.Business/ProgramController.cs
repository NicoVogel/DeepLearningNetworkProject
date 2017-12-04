
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
        private IDataFactory m_df;
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
                    m_dm = this.m_df.CreateDataManager();
                return m_dm;
            }
        }

        public IBusinessFactory BusinessFactory
        {
            get { return m_bf; }
        }

        public IEntityFactory EntityFactory
        {
            get { return m_ef; }
        }

        public int MaxValueForBias
        {
            get { return 10; }
        }

        public int MaxValueForWeight
        {
            get { return 10; }
        }


        #endregion

        #region Constructors



        /// <summary>
        /// default constructor
        /// </summary>
        public ProgramController(IEntityFactory ef, IBusinessFactory bf, IDataFactory df)
        {
            this.m_ef = ef;
            this.m_bf = bf;
            this.m_df = df;
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
            checkInizialiseNetworkParameter(layerCount);

            if (checkObserverAllowOverride(this.Network))
            {
                this.Network = this.EntityFactory.CreateEmptyNetwork();
                IList<INode> previousLayer = null;


                for (int i = 0; i < layerCount.Count; i++)
                {
                    var layer = this.EntityFactory.CreateList<INode>();
                    var type = getNodeType(i, layerCount.Count);

                    for (int j = 0; j < layerCount[i]; j++)
                    {
                        var node = this.EntityFactory.CreateNode();
                        node.NType = type;
                        node.Bias = getRandomDouble(this.MaxValueForBias);

                        if (previousLayer != null)
                        {
                            foreach (var preNode in previousLayer)
                            {
                                var connection = this.EntityFactory.CreateConnection();
                                connection.FromNode = preNode;
                                connection.ToNode = node;
                                connection.Weight = getRandomDouble(this.MaxValueForWeight);
                                node.Connections.Add(connection);
                            }
                        }
                        layer.Add(node);
                    }

                    this.Network.Layers.Add(layer);
                    previousLayer = layer;
                }
            }


        }



        #endregion

        #region private method



        private void checkInizialiseNetworkParameter(IList<int> layerCount)
        {
            if (layerCount == null)
                throw new ArgumentNullException(nameof(layerCount), "Cannot create a network when the parameter which spesifies the netwok buildup is null.");

            if (layerCount.Count < 2)
                throw new ArgumentOutOfRangeException(nameof(layerCount), "Cannot create a network which has less than two layers.");

            var doesNotHaveAnyNodes = this.EntityFactory.CreateList<int>();

            for (int i = 0; i < layerCount.Count; i++)
            {
                if (layerCount[i] <= 0)
                    doesNotHaveAnyNodes.Add(i);
            }

            if (doesNotHaveAnyNodes.Count != 0)
            {
                throw new ArgumentOutOfRangeException("layer node count", 
                    "Cannot create a layer which does not have at least one node. The following layer(s) do not have at least one node: " + 
                    String.Join(", ", doesNotHaveAnyNodes));
            }
        }
        
        private bool checkObserverAllowOverride(INetwork network)
        {
            if(network != null)
            {
                // TODO ask observer if it is ok to override the current network
                network = null;
            }
            return true;
        }

        private Entities.NodeType getNodeType(int currentLayer, int layerCount)
        {
            if (currentLayer == 0)
                return Entities.NodeType.Input;
            else if ((currentLayer + 1) == layerCount)
                return Entities.NodeType.Normal;
            else
                return Entities.NodeType.Output;
        }

        /// <summary>
        /// creates a random double
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        private double getRandomDouble(int maxValue)
        {
            var randomNumber = new Random();
            return Double.Parse(
                randomNumber.Next(maxValue).ToString() + 
                "." +
                randomNumber.Next(9) +
                randomNumber.Next(9));
        }



        #endregion

    }
}
