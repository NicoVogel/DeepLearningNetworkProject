using System.Collections.Generic;

namespace DLNP.Entities.Interfaces
{
    public interface ILayer
    {

        IList<INode> Nodes { get; }

    }
}
