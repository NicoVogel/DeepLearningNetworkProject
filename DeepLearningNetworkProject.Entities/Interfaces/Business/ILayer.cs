using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Business
{
    public interface ILayer
    {

        IList<INode> Nodes { get; }

    }
}
