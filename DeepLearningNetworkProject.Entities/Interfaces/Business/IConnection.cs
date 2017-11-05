

namespace DLNP.Entities.Interfaces.Business
{
    public interface IConnection
    {

        INode FromNode { get; set; }

        INode ToNode { get; set; }

        double Weight { get; set; }

    }
}
