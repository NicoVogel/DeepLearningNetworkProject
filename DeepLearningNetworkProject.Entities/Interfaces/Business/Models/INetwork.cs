using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Business.Models
{
    public interface INetwork
    {

        IList<ILayer> Layers { get; }
        

    }
}
