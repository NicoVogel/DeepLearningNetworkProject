using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Business.Models
{
    public interface ILayer
    {

        IList<INode> Nodes { get; }

    }
}
