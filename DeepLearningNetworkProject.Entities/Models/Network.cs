
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



        #endregion

        #region Constructor



        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="ef"></param>
        public Network(IEntityFactory ef)
        {
            this.m_ef = ef;
        }


        #endregion

    }
}
