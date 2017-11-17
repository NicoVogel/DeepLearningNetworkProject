using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Business.Models
{
    public interface INetwork
    {

        /// <summary>
        /// list of
        /// </summary>
        IList<IList<INode>> Layers { get; }
        
        IList<int> LayerCount { get; }

        int FirstLayerCount { get; }

    }
}
