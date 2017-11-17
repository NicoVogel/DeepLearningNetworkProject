
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



        public int FirstLayerCount
        {
            get
            {
                return this.Layers.Select(x => x.Count).FirstOrDefault();
            }
        }

        public IList<int> LayerCount
        {
            get
            {
                return this.Layers.Select(x => x.Count).ToList();
            }
        }

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
        private IVector getBiasVector(int layer)
        {
            IVector biasVector = MathFactory.CreateVector(this.LayerCount[layer]);

            for(int i = 0; i < this.LayerCount[layer]; i++)
            {
                biasVector[i] = this.Layers.ElementAt(layer).ElementAt(i).Bias;
            }

            return biasVector;
        }

        private IMatrix getConnectionMatrix(int layer)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
