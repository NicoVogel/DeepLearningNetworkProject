
using System;
using System.Collections.Generic;
using DLNP.Entities.Interfaces.Business.Models;
using DLNP.Entities.Interfaces.Factories;
using System.Linq;

namespace DLNP.Entities.Models
{
    public class Network : INetwork
    {

        #region Private Variables


        IEntityFactory m_ef;
        IMathFactory m_mf;
        IList<IList<INode>> m_nodes;


        #endregion

        #region Properties


        /// <summary>
        /// Get count of neurons in the first layer
        /// </summary>
        public int FirstLayerCount
        {
            get
            {
                return this.Layers.Select(x => x.Count).FirstOrDefault();
            }
        }

        /// <summary>
        /// Get count of neurons in a layer
        /// </summary>
        public IList<int> LayerCount
        {
            get
            {
                return this.Layers.Select(x => x.Count).ToList();
            }
        }

        /// <summary>
        /// Get list with all layers
        /// </summary>
        public IList<IList<INode>> Layers
        {
            get
            {
                if (m_nodes == null)
                    m_nodes = this.EntityFactory.CreateList<IList<INode>>();
                return m_nodes;
            }
        }

        public IEntityFactory EntityFactory
        {
            get { return m_ef; }
        }

        public IMathFactory MathFactory
        {
            get { return m_mf; }
        }



        #endregion

        #region Constructor



        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="ef"></param>
        public Network(IEntityFactory ef, IMathFactory mf)
        {
            this.m_ef = ef;

        }


        #endregion


        #region Private Methods


        /// <summary>
        /// Get a vector with all bias values in a layer
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        private IVector getValueVector(int layer)
        {
            if (layer < 0 || layer >= this.Layers.Count)
                throw new ArgumentException($"Layer {layer} does not exist");

            IVector valueVector = MathFactory.CreateVector(this.LayerCount[layer]);

            for (int i = 0; i < this.LayerCount[layer]; i++)
            {
                valueVector[i] = this.Layers.ElementAt(layer).ElementAt(i).Value;
            }

            return valueVector;
        }

        /// <summary>
        /// Get a vector with all bias values in a layer
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        private IVector getBiasVector(int layer)
        {
            if (layer < 0 || layer >= this.Layers.Count)
                throw new ArgumentException($"Layer {layer} does not exist");

            IVector biasVector = MathFactory.CreateVector(this.LayerCount[layer]);

            for(int i = 0; i < this.LayerCount[layer]; i++)
            {
                biasVector[i] = this.Layers.ElementAt(layer).ElementAt(i).Bias;
            }

            return biasVector;
        }

        /// <summary>
        /// Get all connection weights between a layer and its input layer
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        private IMatrix getConnectionWeightMatrix(int layer)
        {
            if (layer < 1)
                throw new ArgumentException($"Can't get connection matrix for layer {layer}");

            IMatrix connectionMatrix = MathFactory.CreateMatrix(this.LayerCount[layer], this.LayerCount[layer - 1]);

            for(int m = 0; m < this.LayerCount[layer]; m++)
            {
                for (int n = 0; n < this.LayerCount[layer - 1]; n++)
                    connectionMatrix[m, n] = this.Layers[layer][m].Connections[n].Weight;
            }

            return connectionMatrix;
        }

        #endregion
    }
}
