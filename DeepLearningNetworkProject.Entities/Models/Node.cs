using System;
using System.Collections.Generic;
using DLNP.Entities.Factory;
using DLNP.Entities.Interfaces.Business.Models;
using DLNP.Entities.Interfaces.Factories;

namespace DLNP.Entities.Models
{
    public class Node : INode
    {

        #region Private Variables



        private double m_bias;
        private IList<IConnection> m_connections;
        private NodeType m_nType;
        private double m_value;
        private IEntityFactory m_ef;



        #endregion

        #region Properties



        /// <summary>
        /// The fixed value which gets added to the value of all connections together
        /// </summary>
        public double Bias
        {
            get { return m_bias; }
            set { m_bias = value; }
        }

        /// <summary>
        /// the connections to all previous nodes
        /// </summary>
        public IList<IConnection> Connections
        {
            get
            {
                if (m_connections == null)
                    m_connections = m_ef.CreateList<IConnection>();
                return m_connections;
            }
        }

        /// <summary>
        /// which type is this node
        /// </summary>
        public NodeType NType
        {
            get { return m_nType; }
            set { m_nType = value; }
        }

        /// <summary>
        /// the value of this node
        /// </summary>
        public double Value
        {
            get { return m_value; }
            set { m_value = value; }
        }



        #endregion

        #region Constructor
        


        /// <summary>
        /// default constructor
        /// </summary>
        public Node(IEntityFactory ef)
        {
            this.m_ef = ef;
        }



        #endregion


    }
}
