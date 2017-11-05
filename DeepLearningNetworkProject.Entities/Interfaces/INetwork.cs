using System.Collections.Generic;

namespace DLNP.Entities.Interfaces
{
    public interface INetwork
    {

        IList<ILayer> Layers { get; }
        

    }
}
