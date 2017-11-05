using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Business
{
    public interface INetwork
    {

        IList<ILayer> Layers { get; }
        

    }
}
