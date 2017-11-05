

using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Business
{
    public interface INode
    {

        NodeType NType { get; set; }

        IList<IConnection> Connections { get; }

        double Bias { get; set; }

        double Value { get; set; }

    }
}
