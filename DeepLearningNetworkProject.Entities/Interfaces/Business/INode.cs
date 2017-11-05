

using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Business
{
    public interface INode
    {
        /// <summary>
        /// which type is this node
        /// </summary>
        NodeType NType { get; set; }
        /// <summary>
        /// the connections to all previous nodes
        /// </summary>
        IList<IConnection> Connections { get; }
        /// <summary>
        /// The fixed value which gets added to the value of all connections together
        /// </summary>
        double Bias { get; set; }
        /// <summary>
        /// the value of this node
        /// </summary>
        double Value { get; set; }

    }
}
