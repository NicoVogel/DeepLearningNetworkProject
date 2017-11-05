using System;
using DLNP.Entities.Interfaces.Business;

namespace DLNP.Entities.Models 
{
    public class Connection : IConnection
    {

        #region Private Variables



        private INode m_fromNode;
        private INode m_toNode;
        private double m_weight;



        #endregion

        #region Properties



        /// <summary>
        /// The node from which the <see cref="Connection"/> starts
        /// </summary>
        public INode FromNode
        {
            get { return m_fromNode; }
            set { m_fromNode = value; }
        }

        /// <summary>
        /// The node to which the <see cref="Connection"/> connects
        /// </summary>
        public INode ToNode
        {
            get { return m_toNode; }
            set { m_toNode = value; }
        }

        /// <summary>
        /// The weight of the connection
        /// </summary>
        public double Weight
        {
            get { return m_weight; }
            set { m_weight = value; }
        }




        #endregion

        #region Constructors



        /// <summary>
        /// default constructor
        /// </summary>
        public Connection()
        {

        }



        #endregion

    }
}
